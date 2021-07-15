using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseResume : MonoBehaviour
{
    public static bool paused = false;
    float gameSpeed = 1;

    Text buttonText;

    // Start is called before the first frame update
    void Start()
    {
        buttonText = GetComponentInChildren<Text>();
    }

    public void PauseResumeGame()
    {
        if (paused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        paused = true;
        buttonText.text = "Resume";
    }

    void ResumeGame()
    {
        Time.timeScale = gameSpeed;
        paused = false;
        buttonText.text = "Pause";
    }

    public void SetGameSpeed(float speed)
    {
        gameSpeed = speed;
        ResumeGame();
    }
}
