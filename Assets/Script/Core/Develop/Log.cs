﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Text;
using System;

public class Log 
{
    //日志输出线程
    static LogOutPutThread s_LogOutPutThread = new LogOutPutThread();
    public static bool isOpenLog= false;
    public static void Init(bool isOpenLog = true)
    {
        Log.isOpenLog = isOpenLog;
#if UNITY_2017_1_OR_NEWER
        Debug.unityLogger.logEnabled = isOpenLog;
#else
        Debug.logger.logEnabled = isOpenLog;
#endif

        if (isOpenLog)
        {
            s_LogOutPutThread.Init();
            ApplicationManager.s_OnApplicationQuit += OnApplicationQuit;
            Application.logMessageReceivedThreaded += UnityLogCallBackThread;
            Application.logMessageReceived += UnityLogCallBack;
        }
    }

    private static void OnApplicationQuit()
    {
        Application.logMessageReceivedThreaded -= UnityLogCallBackThread;
        Application.logMessageReceived -= UnityLogCallBack;
        s_LogOutPutThread.Close();
    }

    static void UnityLogCallBackThread(string log, string track, LogType type)
    {
        LogInfo l_logInfo = new LogInfo
        {
            m_logContent = log,
            m_logTrack = track,
            m_logType = type
        };

        s_LogOutPutThread.Log(l_logInfo);
    }

    static void UnityLogCallBack(string log, string track, LogType type)
    {
        //LogInfo l_logInfo = new LogInfo
        //{
        //    m_logContent = log,
        //    m_logTrack = track,
        //    m_logType = type
        //};
    }
}

public class LogInfo
{
    public string m_logContent;
    public string m_logTrack;
    public LogType m_logType;
}
