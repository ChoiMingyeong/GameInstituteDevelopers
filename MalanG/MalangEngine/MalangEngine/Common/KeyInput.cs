// Copyright MUMO STUDIO, Inc. All Rights Reserved.

using System.Runtime.InteropServices;

namespace MalangEngine.Common;

public class KeyInput : Singleton<KeyInput>
{
    //todo : 윈도우가 활성화 되어있을 때만 작동해야됨
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

    public void Initialize()
    {
        
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