// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangEngine.GameObject;

public class Object : MalangBase
{
    private Scene _scene;
    private readonly List<Component?> _components = new List<Component?>();

    public Object(string name="", string sceneName = "")
    {
        if (string.IsNullOrEmpty(sceneName))
        {
            _scene = SceneManager.Instance.NowScene;
        }
        SceneManager.Instance.NowScene?.AddObject(this);
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