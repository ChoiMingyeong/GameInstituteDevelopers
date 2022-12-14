// Copyright MUMO STUDIO, Inc. All Rights Reserved.

using MalangEngine;
using MalangEngine.Common;
using MalangEngine.GameObject;

namespace MalangEngineTestClient;

public class TutorialScene : Scene
{
    public TutorialScene()
    {
        
    }
    public override void Initialize()
    {
        Console.WriteLine("Tutorial_Initialize");
    }

    public override void Start()
    {
        Console.WriteLine("Tutorial_Start");
    }

    public override void Update()
    {
        if (KeyInput.Instance.IsKeyDown(0x20))
        {
            SceneManager.Instance.ChangeNowScene("InGameScene");
        }
    }
}