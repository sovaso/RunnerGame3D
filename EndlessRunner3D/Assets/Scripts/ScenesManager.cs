using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void MainMenuButtonPressed(){
	SceneManager.LoadScene(0);
    }

    public void MountainButtonPressed(){
	SceneManager.LoadScene(1);
    }

    public void CityButtonPressed(){
	SceneManager.LoadScene(2);
    }

    public void ExitButtonPressed(){
	Application.Quit();
    }
}
