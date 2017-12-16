﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausegame : MonoBehaviour
{
    public bool IsPaused;
    //public GameObject PauseMenu;
    public GameObject PauseText;
   // public GameObject PauseButton;
    //public GameObject ContinueButton;
    public GameObject Restart;

    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (IsPaused)
        {
           // PauseMenu.SetActive(true);
            PauseText.SetActive(true);
            //PauseButton.SetActive(true);
            //ContinueButton.SetActive(true);
            Restart.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
           // PauseMenu.SetActive(false);
            PauseText.SetActive(false);
            //PauseButton.SetActive(false);
            //ContinueButton.SetActive(false);
            Restart.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
        }
    }
    public void continueButton()
    {
        IsPaused = !IsPaused;
    }
}