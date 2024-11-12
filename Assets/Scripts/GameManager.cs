using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 1f;
    }
    public void ResetTheGame()
    {
        SceneManager.LoadScene("Fail");

    }

}
