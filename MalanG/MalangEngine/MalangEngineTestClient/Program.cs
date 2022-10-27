// See https://aka.ms/new-console-template for more information

using MalangEngine;
using MalangEngine.GameObject;

namespace MalangEngineTestClient;

internal static class Program
{
    public static void Main(string[] args)
    {
        var waitHandle = new AutoResetEvent(false);
        
        SceneManager.Instance.Initialize();
        SceneManager.Instance.ChangeNowScene("TitleScene");
        SceneManager.Instance.Run();
        
        waitHandle.WaitOne();    
    }    
}