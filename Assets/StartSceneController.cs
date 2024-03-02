using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartSceneController : MonoBehaviour
{
    public string SampleScene;
    public void LoadScene()
    {
        SceneManager.LoadScene(SampleScene);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
