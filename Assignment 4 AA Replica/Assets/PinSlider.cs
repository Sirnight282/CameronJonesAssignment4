using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSlider : MonoBehaviour
{
    public Slider pinSliderUI;
    public static float pinSliderValueFloat;
    public static Text PinSliderValue;
    void Start()
    {
        PinSliderValue = GetComponent<Text>();
        ShowSliderValue();
    }

    public void ShowSliderValue()
    {
        string sliderMessage = "Pin Speed: " + pinSliderUI.value * .10 + " X";
        PinSliderValue.text = sliderMessage;
        pinSliderValueFloat = pinSliderUI.value / 10;
    }
}
