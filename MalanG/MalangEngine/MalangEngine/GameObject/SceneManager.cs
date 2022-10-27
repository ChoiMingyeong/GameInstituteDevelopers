// Copyright MUMO STUDIO, Inc. All Rights Reserved.

using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using MalangEngine.Common;

namespace MalangEngine.GameObject;

public class SceneManager : Singleton<SceneManager>
{
    public List<Scene?> Scenes { get; private set; } = new();
    public Scene? NowScene { get; private set; } = null;

    private Scene? _currentScene = null;

    private SceneManager()
    {
    }

    public void Initialize()
    {
        foreach(var type in Assembly.GetCallingAssembly().GetTypes())
        {
            if (type.IsSubclassOf(typeof(Scene)))
            {
                Scenes.Add(Activator.CreateInstance(type) as Scene);
            }
        }
        
        foreach (var scene in Scenes)
        {
            scene?.Initialize();
        }
    }

    public void Run()
    {
        Task.Run(Update);
    }

    private void Update()
    {
        //todo : 프레임 계산
        while (true)
        {
            KeyInput.Instance.Update();
            
            if (NowScene != null && !Equals(_currentScene, NowScene))
            {
                NowScene?.Start();
                _currentScene = NowScene;
            }

            NowScene?.Update();
            Thread.Sleep(10);
        }
    }

    public void AddNewScene(Scene? scene)
    {
        NowScene ??= scene;
        Scenes.Add(scene);
    }

    public void AddNewScene(string name)
    {
        var newScene = new Scene();
        AddNewScene(newScene);
    }

    public void ChangeNowScene(string name)
    {
        foreach (var scene in Scenes.Where(scene => scene?.Name == name))
        {
            NowScene = scene;
        }
    }
}