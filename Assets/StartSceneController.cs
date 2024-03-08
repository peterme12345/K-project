using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartSceneController : MonoBehaviour
{
    public string SampleScene;
    public string SettingScene;
    public string StartScene;

    public void LoadScene()
    {
        SceneManager.LoadScene(SampleScene);
    }
    public void Quit(){
        Application.Quit();
    }

    public void Settings(){
        SceneManager.LoadScene(SettingScene);
    }
    // Start is called before the first frame update
    public void Back(){
        SceneManager.LoadScene(StartScene);
    }
}
