using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Text highscore;
    public Text playerName;
    public void Start()
    {
        if (GetPlayerName.Name == "")
        {
            GetPlayerName.Name = "Player";
        }
        highscore.text = GetPlayerName.Name + "'s Highest Score Achieved: " + Score.highestScore.ToString();
        
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("The game has been ended");
    }
}
