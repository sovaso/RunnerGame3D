using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MountainMenuFlow : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public static bool GameIsFinished = false;
    public GameObject pauseMenuUI;
    public GameObject finishMenuUI;
    public GameObject continueStoryMenuUI;
    public GameObject secondLevelIntroductionMenuUI;
    public GameObject deathMenuUI;
    public GameObject progressBarMenu;

    public AudioSource backgroundMusic2;

    public GameObject scoreText;
    int scoreCounter;

    private int scoreLevelMaximum = 7000;

    void Start(){
	GameIsPaused = false;
	GameIsFinished = false;
	Time.timeScale = 1f;

	scoreCounter = Int32.Parse(scoreText.GetComponent<Text>().text);
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
    }

    public void Pause(){
	pauseMenuUI.SetActive(true);
	Time.timeScale = 0f;
	GameIsPaused = true;
    }

    public void WinningScreen(){
	GameIsFinished = true;
	finishMenuUI.SetActive(true);
	Time.timeScale = 0f;
    }

    public void ContinueStoryScreen(){
	progressBarMenu.SetActive(false);
	finishMenuUI.SetActive(false);
	backgroundMusic2.Play();
	continueStoryMenuUI.SetActive(true);
    }

    public void SecondLevelIntroductionScreen(){
	continueStoryMenuUI.SetActive(false);
	secondLevelIntroductionMenuUI.SetActive(true);
    }

    public void DeathScreen(){
	GameIsFinished = true;
	deathMenuUI.SetActive(true);
	Time.timeScale = 0f;
    }
}
