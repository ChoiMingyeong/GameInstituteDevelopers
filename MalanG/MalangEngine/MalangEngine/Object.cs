// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangEngine;

public class Object : MalangBase
{
    private readonly List<Component?> _components = new List<Component?>();
    
    public Object(string name)
    {
        
    }

    public override void Update()
    {
        foreach (var component in _components)
        {
            component?.Update();
        }
    }

    public Component? GetComponent<T>()
    {
        return _components.FirstOrDefault(component => component is T);
    }
}