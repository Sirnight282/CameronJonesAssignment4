using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public static float Timer;
    public Text text;
    void Start()
    {
        Timer = TimerSlider.timerSliderValueFloat;
    }

    
    void Update()
    {
        text.text = Timer.ToString("F2");
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
