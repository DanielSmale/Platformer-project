﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void PlayLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
