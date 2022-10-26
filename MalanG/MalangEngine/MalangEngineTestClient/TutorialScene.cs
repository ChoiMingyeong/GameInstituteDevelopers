// Copyright MUMO STUDIO, Inc. All Rights Reserved.

using MalangEngine;

namespace MalangEngineTestClient;

public class TutorialScene : Scene
{
    public TutorialScene():base("Tutorial")
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
        //Console.WriteLine("Tutorial_Update");
        if (KeyInput.Instance.IsKeyDown(0x20))
        {
            SceneManager.Instance.ChangeNowScene("InGame");
        }
    }
}