// Copyright MUMO STUDIO, Inc. All Rights Reserved.

using MalangEngine;
using MalangEngine.Common;
using MalangEngine.GameObject;

namespace MalangEngineTestClient;

[GameScene]
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
        //Console.WriteLine("Title_Update");

        if (KeyInput.Instance.IsKeyDown(0x20))
        {
            SceneManager.Instance.ChangeNowScene("Tutorial");
        }
    }
}