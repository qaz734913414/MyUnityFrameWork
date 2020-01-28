﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
/// <summary>
/// 重发消息管理器
/// </summary>
public class ResendMessageManager
{
    private const string ResendMsgFile = "ResendMsgFile";
    public static float resendTime = 2f;
    /// <summary>
    /// 开始重发，一般是登陆后
    /// </summary>
    public static bool startResend = false;
    //private static int indexCode = 0;
    public static void Init()
    {
        ApplicationManager.s_OnApplicationUpdate += Update;
        ApplicationManager.s_OnApplicationQuit += OnApplicationQuit;
        InputManager.AddAllEventListener<InputNetworkMessageEvent>(MessageReceiveCallBack);
        LoadRecord();
    }

    private static void MessageReceiveCallBack(InputNetworkMessageEvent inputEvent)
    {
       

        if (msgs.Count == 0)
            return;
        foreach(ResendMessage m in msgs)
        {
            if(m.removeMT==inputEvent.m_MessgaeType)
            {
                msgs.Remove(m);
                if (m.callBack != null)
                {
                    MessageClassInterface msgInterface = null;
                    Type type = Type.GetType(inputEvent.m_MessgaeType);

                    if (type == null)
                    {
                        Debug.LogError("No MessgaeType :" + inputEvent.m_MessgaeType);

                    }
                    else
                    {
                        object dataObj = JsonUtils.FromJson(type, inputEvent.Data["Content"].ToString());
                        msgInterface = (MessageClassInterface)dataObj;
                    }

                    m.callBack(msgInterface);
                }
                break;
            }
        }
    }

    private static void LoadRecord()
    {
        string res = RecordManager.GetStringRecord(ResendMsgFile, "0", "");
        //string res1 = RecordManager.GetStringRecord(ResendMsgFile, "1", "");
        //if (!string.IsNullOrEmpty(res1))
        //    indexCode = int.Parse(res1);
        if (string.IsNullOrEmpty(res))
            return;
        msgs = JsonUtils.FromJson<List<ResendMessage>>(res);
    }

    private static void OnApplicationQuit()
    {
       
            String json = JsonUtils.ToJson(msgs);
            RecordManager.SaveRecord(ResendMsgFile, "0", json);
            //RecordManager.SaveRecord(ResendMsgFile, "1", indexCode.ToString());
        
    }
    private static float tempResendTime = 0;
    private static void Update()
    {
        //Debug.Log(msgs.Count+" :"+ startResend+" :"+ tempResendTime);

        if (msgs.Count == 0)
            return;
        if (!startResend)
            return;

        if (tempResendTime > 0)
        {
            tempResendTime -= Time.deltaTime;
            return;
        }
        tempResendTime = resendTime;
        foreach (ResendMessage m in msgs)
        {
            //Debug.LogWarning(m.mt + " :" + m.noSend);
            if (m.noSend)
                continue;
            JsonMessageProcessingController.SendMessage(m.mt, m.content);
        }
    }
    static List<ResendMessage> msgs = new List<ResendMessage>();


    public static void AddResendMessage<T>(T data,string removeMT,CallBack<MessageClassInterface> callBack, bool noSend=false)
    {
        string mt = typeof(T).Name;
        ResendMessage msgResnd = null;
        foreach (ResendMessage m in msgs)
        {
            if (m.mt == mt)
            {
                msgResnd = m;
                break;
            }
        }
            string content = JsonUtils.ToJson(data);
        //Debug.LogError("noSend:" + noSend);
        if (msgResnd != null)
        {
            msgResnd.removeMT = removeMT;
            msgResnd.content = content;
            msgResnd.callBack = callBack;
            msgResnd.noSend = noSend;
            //Debug.LogError("msgResnd.noSend:" + msgResnd.noSend);
        }
        else
        {
            ResendMessage msg = new ResendMessage(removeMT, mt, content, callBack, noSend);
            msgs.Add(msg);
        }
       // JsonMessageProcessingController.SendMessage(mt, content);
        //indexCode++;
    }

    public class ResendMessage
    {
        public string removeMT;
        public string mt;
        public string content;
        /// <summary>
        /// 不发消息（也不重发），只监听接收
        /// </summary>
        public bool noSend = false;
        public CallBack<MessageClassInterface> callBack;
        public ResendMessage() { }
        public ResendMessage(string removeMT, string mt, string content,CallBack<MessageClassInterface> callBack, bool noSend)
        {
            this.removeMT = removeMT;
            this.mt = mt;
            this.content = content;
            this.callBack = callBack;
            this.noSend = noSend;
        }
    }
}

