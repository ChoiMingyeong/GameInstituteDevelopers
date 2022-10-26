// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangEngine.GameObject;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class GameScene : Attribute
{
    public GameScene()
    {
        
    }
}

[GameScene]
public class Scene : MalangBase
{
    private ObjectManager ObjectManager = new ObjectManager();
    public Scene()
    {
        Name = this.GetType().Name;
    }

    public override void Initialize()
    {
        
    }
    public override void Start()
    {
        
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