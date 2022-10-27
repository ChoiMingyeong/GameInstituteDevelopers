// Copyright MUMO STUDIO, Inc. All Rights Reserved.

using MalangEngine;
using MalangEngine.Common;
using MalangEngine.GameObject;

namespace MalangEngineTestClient;

public class TitleScene : Scene
{
    public TitleScene()
    {

    }

    public override void Initialize()
    {
        Console.WriteLine("Title_Initialize");
    }

    public override void Start()
    {
        Console.WriteLine("Title_Start");
    }

    public override void Update()
    {
        if (KeyInput.Instance.IsKeyDown(0x20))
        {
            SceneManager.Instance.ChangeNowScene("TutorialScene");
        }
    }
}