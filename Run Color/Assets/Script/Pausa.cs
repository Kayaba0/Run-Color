using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class Pausa : MonoBehaviour {

    public GameObject pause;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pausa()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }

        pause.SetActive(true);
        //Application.LoadLevelAdditive(2);
    }

    public void escipausa()
    {
        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }
        pause.SetActive(false);
       // SceneManager.UnloadScene(2);

    }

    public void home()
    {
        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }
        pause.SetActive(false);
        //SceneManager.UnloadScene(2);
      
        SceneManager.LoadScene(0);
    }
}
