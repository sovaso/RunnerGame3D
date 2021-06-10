using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityMenuFlow : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public static bool GameIsFinished = false;
    public GameObject pauseMenuUI;
    public GameObject finishMenuUI;
    public GameObject endMenuUI;
    public GameObject deathMenuUI;
    public GameObject progressBarMenu;

    public AudioSource backgroundMusic2;
    public AudioSource runningSound;

    public GameObject scoreText;
    int scoreCounter;

    private int scoreLevelMaximum = 10000;

    void Start(){
	GameIsPaused = false;
	GameIsFinished = false;
	Time.timeScale = 1f;

	scoreCounter = Int32.Parse(scoreText.GetComponent<Text>().text);
	runningSound.Play();
    }   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !GameIsFinished)
	{
	    if (GameIsPaused)
	    {
		Resume();
            } else
	    {
		Pause();
	    }
	}

	scoreCounter = Int32.Parse(scoreText.GetComponent<Text>().text);
	if (scoreCounter >= scoreLevelMaximum && !GameIsFinished){
	    WinningScreen();
	} 
	if (scoreCounter <= -scoreLevelMaximum && !GameIsFinished) {
	    DeathScreen();
	}
    }

    public void Resume(){
	pauseMenuUI.SetActive(false);
	Time.timeScale = 1f;
	GameIsPaused = false;
	runningSound.Play();
    }

    public void Pause(){
	pauseMenuUI.SetActive(true);
	Time.timeScale = 0f;
	GameIsPaused = true;
	runningSound.Stop();
    }

    public void WinningScreen(){
	runningSound.Stop();
	GameIsFinished = true;
	finishMenuUI.SetActive(true);
	Time.timeScale = 0f;
    }

    public void EndScreen(){
	backgroundMusic2.Play();
	progressBarMenu.SetActive(false);
	finishMenuUI.SetActive(false);
	endMenuUI.SetActive(true);
    }

    public void DeathScreen(){
	runningSound.Stop();
	GameIsFinished = true;
	deathMenuUI.SetActive(true);
	Time.timeScale = 0f;
    }
}
