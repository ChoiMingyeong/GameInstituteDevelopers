// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangEngine;

public class Scene : MalangBase
{
    private ObjectManager ObjectManager = new ObjectManager();
    public Scene(string name) : base(name)
    {
        SceneManager.Instance.AddNewScene(this);
    }

    public override void Update()
    {
        ObjectManager.Update();
    }

    public void AddObject()
    {
        ObjectManager.AddObject();
    }

    public void AddObject(string name)
    {
        ObjectManager.AddObject(name);
    }
}