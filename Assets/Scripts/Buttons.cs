using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField] private Text myText;

    public void ClickButton()
    {
        if (isPaused)
        {
            ClickPlay();
        }
        else
        {
            ClickPause();
        }
    }


    public void ClickPause()
    {
        Time.timeScale = 0f;
        isPaused = true;
        myText.text = "Play";
    }

    public void ClickPlay()
    {
        Time.timeScale = 1f;
        isPaused = false;
        myText.text = "Pause";
    }

    public void ClickExit()
    {
        Application.Quit();
    }

}
