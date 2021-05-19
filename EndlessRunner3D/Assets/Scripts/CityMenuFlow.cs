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

    public GameObject scoreText;
    int scoreCounter;

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
	if (scoreCounter > 1000){
	    WinningScreen();
	} 
	if (scoreCounter < -10000) {
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
	//pauseMenuUI.SetActive(false);
	finishMenuUI.SetActive(true);
	//endMenuUI.SetActive(false);
	Time.timeScale = 0f;
    }

    public void EndScreen(){
	//pauseMenuUI.SetActive(false);
	finishMenuUI.SetActive(false);
	endMenuUI.SetActive(true);
    }

    public void DeathScreen(){
	GameIsFinished = true;
	//pauseMenuUI.SetActive(false);
	deathMenuUI.SetActive(true);
	//endMenuUI.SetActive(false);
	Time.timeScale = 0f;
    }
}
