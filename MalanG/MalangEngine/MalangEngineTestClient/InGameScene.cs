// Copyright MUMO STUDIO, Inc. All Rights Reserved.

using MalangEngine;
using MalangEngine.Common;
using MalangEngine.GameObject;

namespace MalangEngineTestClient;

[GameScene]
public class InGameScene : Scene
{
    public InGameScene()
    {
    }
    
    public override void Initialize()
    {
        Console.WriteLine("InGame_Initialize");
    }

    public override void Start()
    {
        Console.WriteLine("InGame_Start");
    }

    public override void Update()
    {
        if (KeyInput.Instance.IsKeyDown(0x20))
        {
            SceneManager.Instance.ChangeNowScene("Title");
        }
    }
}