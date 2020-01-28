﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_InputWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Input), typeof(System.Object));
		L.RegFunction("GetAxis", GetAxis);
		L.RegFunction("GetAxisRaw", GetAxisRaw);
		L.RegFunction("GetButton", GetButton);
		L.RegFunction("GetButtonDown", GetButtonDown);
		L.RegFunction("GetButtonUp", GetButtonUp);
		L.RegFunction("GetKey", GetKey);
		L.RegFunction("GetKeyDown", GetKeyDown);
		L.RegFunction("GetKeyUp", GetKeyUp);
		L.RegFunction("GetJoystickNames", GetJoystickNames);
		L.RegFunction("GetMouseButton", GetMouseButton);
		L.RegFunction("GetMouseButtonDown", GetMouseButtonDown);
		L.RegFunction("GetMouseButtonUp", GetMouseButtonUp);
		L.RegFunction("ResetInputAxes", ResetInputAxes);
		L.RegFunction("GetAccelerationEvent", GetAccelerationEvent);
		L.RegFunction("GetTouch", GetTouch);
		L.RegFunction("New", _CreateUnityEngine_Input);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("compensateSensors", get_compensateSensors, set_compensateSensors);
		L.RegVar("gyro", get_gyro, null);
		L.RegVar("mousePosition", get_mousePosition, null);
		L.RegVar("mouseScrollDelta", get_mouseScrollDelta, null);
		L.RegVar("mousePresent", get_mousePresent, null);
		L.RegVar("simulateMouseWithTouches", get_simulateMouseWithTouches, set_simulateMouseWithTouches);
		L.RegVar("anyKey", get_anyKey, null);
		L.RegVar("anyKeyDown", get_anyKeyDown, null);
		L.RegVar("inputString", get_inputString, null);
		L.RegVar("acceleration", get_acceleration, null);
		L.RegVar("accelerationEvents", get_accelerationEvents, null);
		L.RegVar("accelerationEventCount", get_accelerationEventCount, null);
		L.RegVar("touches", get_touches, null);
		L.RegVar("touchCount", get_touchCount, null);
		L.RegVar("touchPressureSupported", get_touchPressureSupported, null);
		L.RegVar("stylusTouchSupported", get_stylusTouchSupported, null);
		L.RegVar("touchSupported", get_touchSupported, null);
		L.RegVar("multiTouchEnabled", get_multiTouchEnabled, set_multiTouchEnabled);
		L.RegVar("location", get_location, null);
		L.RegVar("compass", get_compass, null);
		L.RegVar("deviceOrientation", get_deviceOrientation, null);
		L.RegVar("imeCompositionMode", get_imeCompositionMode, set_imeCompositionMode);
		L.RegVar("compositionString", get_compositionString, null);
		L.RegVar("imeIsSelected", get_imeIsSelected, null);
		L.RegVar("compositionCursorPos", get_compositionCursorPos, set_compositionCursorPos);
		L.RegVar("backButtonLeavesApp", get_backButtonLeavesApp, set_backButtonLeavesApp);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Input(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Input obj = new UnityEngine.Input();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Input.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAxis(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			float o = UnityEngine.Input.GetAxis(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAxisRaw(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			float o = UnityEngine.Input.GetAxisRaw(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetButton(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = UnityEngine.Input.GetButton(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetButtonDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = UnityEngine.Input.GetButtonDown(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetButtonUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = UnityEngine.Input.GetButtonUp(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetKey(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.KeyCode)))
			{
				UnityEngine.KeyCode arg0 = (UnityEngine.KeyCode)ToLua.ToObject(L, 1);
				bool o = UnityEngine.Input.GetKey(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				bool o = UnityEngine.Input.GetKey(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Input.GetKey");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetKeyDown(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.KeyCode)))
			{
				UnityEngine.KeyCode arg0 = (UnityEngine.KeyCode)ToLua.ToObject(L, 1);
				bool o = UnityEngine.Input.GetKeyDown(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				bool o = UnityEngine.Input.GetKeyDown(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Input.GetKeyDown");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetKeyUp(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.KeyCode)))
			{
				UnityEngine.KeyCode arg0 = (UnityEngine.KeyCode)ToLua.ToObject(L, 1);
				bool o = UnityEngine.Input.GetKeyUp(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				bool o = UnityEngine.Input.GetKeyUp(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Input.GetKeyUp");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetJoystickNames(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string[] o = UnityEngine.Input.GetJoystickNames();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMouseButton(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			bool o = UnityEngine.Input.GetMouseButton(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMouseButtonDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			bool o = UnityEngine.Input.GetMouseButtonDown(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMouseButtonUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			bool o = UnityEngine.Input.GetMouseButtonUp(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetInputAxes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Input.ResetInputAxes();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAccelerationEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.AccelerationEvent o = UnityEngine.Input.GetAccelerationEvent(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTouch(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.Touch o = UnityEngine.Input.GetTouch(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_compensateSensors(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.compensateSensors);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gyro(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, UnityEngine.Input.gyro);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mousePosition(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Input.mousePosition);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mouseScrollDelta(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Input.mouseScrollDelta);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mousePresent(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.mousePresent);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_simulateMouseWithTouches(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.simulateMouseWithTouches);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anyKey(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.anyKey);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anyKeyDown(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.anyKeyDown);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inputString(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Input.inputString);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_acceleration(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Input.acceleration);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_accelerationEvents(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Input.accelerationEvents);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_accelerationEventCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Input.accelerationEventCount);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_touches(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Input.touches);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_touchCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Input.touchCount);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_touchPressureSupported(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.touchPressureSupported);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_stylusTouchSupported(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.stylusTouchSupported);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_touchSupported(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.touchSupported);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_multiTouchEnabled(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.multiTouchEnabled);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_location(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, UnityEngine.Input.location);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_compass(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, UnityEngine.Input.compass);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deviceOrientation(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Input.deviceOrientation);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_imeCompositionMode(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Input.imeCompositionMode);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_compositionString(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Input.compositionString);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_imeIsSelected(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.imeIsSelected);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_compositionCursorPos(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Input.compositionCursorPos);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_backButtonLeavesApp(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Input.backButtonLeavesApp);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_compensateSensors(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Input.compensateSensors = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_simulateMouseWithTouches(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Input.simulateMouseWithTouches = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_multiTouchEnabled(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Input.multiTouchEnabled = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_imeCompositionMode(IntPtr L)
	{
		try
		{
			UnityEngine.IMECompositionMode arg0 = (UnityEngine.IMECompositionMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.IMECompositionMode));
			UnityEngine.Input.imeCompositionMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_compositionCursorPos(IntPtr L)
	{
		try
		{
			UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector2));
			UnityEngine.Input.compositionCursorPos = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_backButtonLeavesApp(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Input.backButtonLeavesApp = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

