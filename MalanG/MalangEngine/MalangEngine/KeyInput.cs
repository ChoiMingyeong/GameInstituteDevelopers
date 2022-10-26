// Copyright MUMO STUDIO, Inc. All Rights Reserved.

using System.Runtime.InteropServices;
using System.Security.Principal;

namespace MalangEngine;

public class KeyInput : Singleton<KeyInput>
{
    private const int KeyCount = 0xff;
    private int[] _prevKeyState;
    private int[] _nowKeyState;

    [DllImport("User32.dll")]
    private static extern short GetAsyncKeyState(int vKey);

    private KeyInput()
    {
        _prevKeyState = new int[KeyCount];
        _nowKeyState = new int[KeyCount];
    }

    public void Update()
    {
        for (var i = 0; i < KeyCount; i++)
        {
            _prevKeyState[i] = _nowKeyState[i];
            _nowKeyState[i] = GetAsyncKeyState(i);
        }
    }

    public bool IsKeyDown(uint keyCode)
    {
        if (keyCode >= KeyCount)
            return false;

        return (_prevKeyState[keyCode] == 0) && ((_nowKeyState[keyCode] & 0x8000) != 0);
    }

    public bool IsKeyUp(int keyCode)
    {
        return ((_prevKeyState[keyCode] & 0x8000) != 0) && (_nowKeyState[keyCode] == 0);
    }

    public bool IsKeyPress(int keyCode)
    {
        return ((_prevKeyState[keyCode] & 0x8000) != 0) && ((_nowKeyState[keyCode] & 0x8000) != 0);
    }
}