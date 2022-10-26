// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangEngine;

public class MalangBase
{
    public string Key { get; private set; }= Guid.NewGuid().ToString();
    public string Name;

    public MalangBase(string name)
    {
        Name = name;
    }

    public MalangBase()
    {
        Name = string.Empty;
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