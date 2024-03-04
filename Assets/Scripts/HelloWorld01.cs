using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class HelloWorld01 : MonoBehaviour
{
    private void Start()
    {
        LuaEnv luaenv = new LuaEnv();
        // 使用xLua打印，带有Lua的标识
        //luaenv.DoString("print('Hellow World!')");

        // 在Lua中调用C#中的类和方法，无Lua的标识
        luaenv.DoString(" CS.UnityEngine.Debug.Log('Hello World!') ");

        // 释放
        luaenv.Dispose();
    }

    private void Update()
    {

    }

    private void OnDestroy()
    {
        // 或者在这里释放
        //luaenv.Dispose();
    }
}
