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

        // �ͷ�
        luaenv.Dispose();
    }

    private void Update()
    {

    }

    private void OnDestroy()
    {
        //// �����������ͷ�
        //// �ͷ�
        //luaenv.Dispose();
    }
}
