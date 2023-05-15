using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillSongBar : MonoBehaviour
{
    public Slider slider;   
    private bool condition = true;

    private int previousNumChildren = 0;


    public void updateSlider(float newVal){
        slider.value += newVal;
    }

    

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject PlayArea = GameObject.Find("PlayArea");
        int numChildren = PlayArea.transform.childCount;

        if (numChildren > previousNumChildren && condition)
        {
            updateSlider(.05f);
            condition = false;
        }
  
        condition = true;
        
        previousNumChildren = numChildren;

    }
}
