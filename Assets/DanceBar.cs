using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DanceBar : MonoBehaviour
{
    public Slider slider;   
    private bool condition = true;

    public Slider SongBar;

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
        
        float sliderValue = SongBar.value;
        if (sliderValue>(.25+slider.value) && condition)
        {
            updateSlider(.05f);
            condition = false;
        }
        condition = true;

    }
}
