using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuFlow : MonoBehaviour
{

    public GameObject startingMenuUI;
    public GameObject helpMenuUI;
    public GameObject pickLevelMenuUI;
    public GameObject startOfStoryMenuUI;
    public GameObject continueOfStoryMenuUI;
    public GameObject introductionFirstLevelMenuUI;

    public AudioSource backgroundMusic1;
    public AudioSource backgroundMusic2;

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HelpButton(){
	startingMenuUI.SetActive(false);
	helpMenuUI.SetActive(true);
    }

    public void HelpBackButton(){
	startingMenuUI.SetActive(true);
	helpMenuUI.SetActive(false);
    }

    public void PickLevelButton(){
	startingMenuUI.SetActive(false);
	pickLevelMenuUI.SetActive(true);
    }

    public void PickLevelBackButton(){
	startingMenuUI.SetActive(true);
	pickLevelMenuUI.SetActive(false);
    }

    public void StartAdventureButton(){
	backgroundMusic1.Stop();
	backgroundMusic2.Play();
	startingMenuUI.SetActive(false);
	startOfStoryMenuUI.SetActive(true);
    }

    public void StartStoryButton(){
	startOfStoryMenuUI.SetActive(false);
	continueOfStoryMenuUI.SetActive(true);
    }

    public void ContinueStoryButton(){
	continueOfStoryMenuUI.SetActive(false);
	introductionFirstLevelMenuUI.SetActive(true);
    }
}
