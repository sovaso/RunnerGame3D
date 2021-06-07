using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

    public RectTransform fader;

    void Start(){
	//fader.gameObject.SetActive(true);
	LeanTween.scale (fader, new Vector3 (1, 1, 1), 0);
        LeanTween.scale (fader, Vector3.zero, 1f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() => {
            fader.gameObject.SetActive (false);
        });
    }

    public void MainMenuButtonPressed(){
	Time.timeScale = 1f;
	fader.gameObject.SetActive(true);
	LeanTween.scale (fader, Vector3.zero, 0f);
        LeanTween.scale (fader, new Vector3 (1, 1, 1), 0.2f).setEase (LeanTweenType.easeInOutQuad).setOnComplete (() => {
	    SceneManager.LoadScene(0);
	});
    }

    public void MountainButtonPressed(){
	Time.timeScale = 1f;
	fader.gameObject.SetActive(true);
	LeanTween.scale (fader, Vector3.zero, 0f);
        LeanTween.scale (fader, new Vector3 (1, 1, 1), 0.2f).setEase (LeanTweenType.easeInOutQuad).setOnComplete (() => {
	    SceneManager.LoadScene(1);
	});
    }

    public void CityButtonPressed(){
	Time.timeScale = 1f;
	fader.gameObject.SetActive(true);
	LeanTween.scale (fader, Vector3.zero, 0f);
        LeanTween.scale (fader, new Vector3 (1, 1, 1), 0.2f).setEase (LeanTweenType.easeInOutQuad).setOnComplete (() => {
	    SceneManager.LoadScene(2);
	});
    }

    public void ExitButtonPressed(){
	Application.Quit();
    }
}
