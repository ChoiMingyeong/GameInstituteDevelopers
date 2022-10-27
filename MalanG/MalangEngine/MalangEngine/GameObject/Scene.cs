// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangEngine.GameObject;

public class Scene : MalangBase
{
    private ObjectManager _objectManager = new ObjectManager();
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
        _objectManager.Update();
    }

    public void AddObject(Object obj)
    {
        _objectManager.AddObject(obj);
    }
}