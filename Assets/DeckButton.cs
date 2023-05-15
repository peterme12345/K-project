using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeckButton : MonoBehaviour
{

    public void OnButtonClick(){
        SceneManager.LoadScene("Scenes/BuildDeckScene");
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
