using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount;     //was float for some reason, just in case change to int messes stuff up
    public Text text;
    public Text livesText;
    public static int Lives = SelectLives.Lives;
    public static int highestScore;
    private void Start()
    {
        PinCount = 0;               // was float needs f if changed back
        livesText.text = Lives.ToString();
        
        
    }

    private void Update()
    {
        text.text = PinCount.ToString();
        livesText.text = Lives.ToString();
    }
}
