using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSlider : MonoBehaviour
{
    public Slider timerSliderUI;
    public static float timerSliderValueFloat;
    public static Text timerSliderValue;
    void Start()
    {
        timerSliderValue = GetComponent<Text>();
        ShowSliderValue();
    }

    public void ShowSliderValue()
    {
        string sliderMessage = "Starting Timer: " + timerSliderUI.value + " X";
        timerSliderValue.text = sliderMessage;
        timerSliderValueFloat = timerSliderUI.value;
    }
}
