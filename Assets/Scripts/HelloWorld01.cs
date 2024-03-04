using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class HelloWorld01 : MonoBehaviour
{
    private void Start()
    {
        LuaEnv luaenv = new LuaEnv();
        luaenv.DoString("print('Hellow World!')");

        // 释放
        luaenv.Dispose();
    }

    private void Update()
    {

    }

    private void OnDestroy()
    {
        //// 或者在这里释放
        //// 释放
        //luaenv.Dispose();
    }
}
