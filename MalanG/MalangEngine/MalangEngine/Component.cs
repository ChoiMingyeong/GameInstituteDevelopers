// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangEngine;

[AttributeUsage(AttributeTargets.Class)]
public class Component : Attribute
{
    public string Name;

    public Component(string name)
    {
        Name = name;
    }
    
    public virtual void Initialize()
    {
        
    }
    
    public virtual void Start()
    {
        
    }

    public virtual void Update()
    {
        
    }
}