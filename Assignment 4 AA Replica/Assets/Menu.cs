using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool Tutorial = false;
    public void Start()
    {
        Score.highestScore = 0;
    }
    public void NextScene()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ToggleTutorial()
    {
        Tutorial = !Tutorial;
    }
}
