// See https://aka.ms/new-console-template for more information

using MalangEngine;
using MalangEngine.GameObject;

namespace MalangEngineTestClient;

internal static class Program
{
    public static void Main(string[] args)
    {
        var waitHandle = new AutoResetEvent(false);
        
        var titleScene = new TitleScene();
        var tutorialScene = new TutorialScene();
        var ingameScene = new InGameScene();
        
        SceneManager.Instance.Initialize();
        SceneManager.Instance.ChangeNowScene(titleScene.Name);
        SceneManager.Instance.Run();
        
        waitHandle.WaitOne();    
    }    
}