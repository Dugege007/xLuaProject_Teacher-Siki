using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class HelloWorld01 : MonoBehaviour
{
    private void Start()
    {
        LuaEnv luaenv = new LuaEnv();
        // ʹ��xLua��ӡ������Lua�ı�ʶ
        //luaenv.DoString("print('Hellow World!')");

        // ��Lua�е���C#�е���ͷ�������Lua�ı�ʶ
        luaenv.DoString(" CS.UnityEngine.Debug.Log('Hello World!') ");

        // �ͷ�
        luaenv.Dispose();
    }

    private void Update()
    {

    }

    private void OnDestroy()
    {
        // �����������ͷ�
        //luaenv.Dispose();
    }
}
