// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangEngine;

public class SceneManager : Singleton<SceneManager>
{
    public List<Scene?> Scenes { get; private set; } = new();
    public Scene? NowScene { get; private set; } = null;

    private Scene? CurrentScene = null;

    private SceneManager()
    {
    }

    public void Initialize()
    {
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
            
            if (NowScene != null && CurrentScene != NowScene)
            {
                NowScene?.Start();
                CurrentScene = NowScene;
            }

            NowScene?.Update();
            Thread.Sleep(10);
        }
    }

    public void AddNewScene(Scene scene)
    {
        NowScene ??= scene;
        Scenes.Add(scene);
    }

    public void AddNewScene(string name)
    {
        var newScene = new Scene(name);
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