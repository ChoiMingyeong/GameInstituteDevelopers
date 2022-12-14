// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangEngine.GameObject;

public class ObjectManager : MalangBase
{
    private static uint _defaultNameNumber = 0;
    public List<Object> Objects = new List<Object>();

    public override void Update()
    {
        foreach (var obj in Objects)
        {
            obj.Update();
        }
    }

    public void AddObject(Object obj)
    {
        if (string.IsNullOrEmpty(obj.Name))
        {
            obj.Name = $"MalangObject_{_defaultNameNumber++}";
        }
        Objects.Add(obj);
    }
}