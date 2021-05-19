﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityGameFlow : MonoBehaviour
{
    public Transform tileObj;
    private Vector3 nextTileSpawn;

    public Transform normalObstacleObj;
    private Vector3 normalObstacleSpawn;
    public Transform longObstacleObj;
    private Vector3 longObstacleSpawn;
    public Transform fullObstacleObj;
    private Vector3 fullObstacleSpawn;
    public Transform GemObj;
    private Vector3 GemSpawn;
    private int randX1;
    private int randX2;

    public GameObject scoreText;
    int scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
	nextTileSpawn.z = 20f;
        StartCoroutine(spawnTile());

	scoreCounter = 0;
	scoreText.GetComponent<Text>().text = scoreCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
	if (Time.timeScale != 0f){
	    scoreCounter = Int32.Parse(scoreText.GetComponent<Text>().text);
	    scoreCounter += 1;
	    scoreText.GetComponent<Text>().text = scoreCounter.ToString();
	} 
    }
    IEnumerator spawnTile()
    {
	yield return new WaitForSeconds(1);

	Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
	randX1 = UnityEngine.Random.Range(0,6);
	if (randX1 == 0){
	    normalObstacleSpawn = nextTileSpawn;
	    normalObstacleSpawn.x = 0.4f;
	    Instantiate(normalObstacleObj, normalObstacleSpawn, normalObstacleObj.rotation);
	    normalObstacleSpawn.x = 0f;
	    Instantiate(normalObstacleObj, normalObstacleSpawn, normalObstacleObj.rotation);
	} else if (randX1 == 1){
	    normalObstacleSpawn = nextTileSpawn;
	    normalObstacleSpawn.x = -0.4f;
	    Instantiate(normalObstacleObj, normalObstacleSpawn, normalObstacleObj.rotation);
	    normalObstacleSpawn.x = 0.4f;
	    Instantiate(normalObstacleObj, normalObstacleSpawn, normalObstacleObj.rotation);
	} else if (randX1 == 2){
	    normalObstacleSpawn = nextTileSpawn;
	    normalObstacleSpawn.x = -0.4f;
	    Instantiate(normalObstacleObj, normalObstacleSpawn, normalObstacleObj.rotation);
	    normalObstacleSpawn.x = 0f;
	    Instantiate(normalObstacleObj, normalObstacleSpawn, normalObstacleObj.rotation);
	} else if (randX1 == 3){
	    longObstacleSpawn = nextTileSpawn;
	    longObstacleSpawn.x = -0.4f;
	    Instantiate(longObstacleObj, longObstacleSpawn, longObstacleObj.rotation);	
	} else if (randX1 == 4){
	    longObstacleSpawn = nextTileSpawn;
	    longObstacleSpawn.x = 0f;
	    Instantiate(longObstacleObj, longObstacleSpawn, longObstacleObj.rotation);
	} else {
	    longObstacleSpawn = nextTileSpawn;
	    longObstacleSpawn.x = 0.4f;
	    Instantiate(longObstacleObj, longObstacleSpawn, longObstacleObj.rotation);
	}
	nextTileSpawn.z += 2.5f;

	Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
	randX2 = UnityEngine.Random.Range(0,3);
	if (randX2 == 0){
	    GemSpawn = nextTileSpawn;
	    GemSpawn.x = -0.35f;
	    Instantiate(GemObj, GemSpawn, GemObj.rotation);
	} else if (randX2 == 1){
	    GemSpawn = nextTileSpawn;
	    GemSpawn.x = 0.35f;
	    Instantiate(GemObj, GemSpawn, GemObj.rotation);
	} else {
	    fullObstacleSpawn = nextTileSpawn;
	    Instantiate(fullObstacleObj, fullObstacleSpawn, fullObstacleObj.rotation);	
	} 
	nextTileSpawn.z += 2.5f;

	StartCoroutine(spawnTile());
    }
}
