using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameflow : MonoBehaviour
{
    public Transform tileObj;
    private Vector3 nextTileSpawn;

    public GameObject scoreText;
    int scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
	nextTileSpawn.z = 12.5f;
        StartCoroutine(spawnTile());

	scoreCounter = 0;
	scoreText.GetComponent<Text>().text = scoreCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
	if (Time.timeScale != 0f){
	    scoreCounter += 1;
	    scoreText.GetComponent<Text>().text = scoreCounter.ToString();
	} 
    }
    IEnumerator spawnTile()
    {
	yield return new WaitForSeconds(1);
	Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
	nextTileSpawn.z += 2.5f;
	Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
	nextTileSpawn.z += 2.5f;
	StartCoroutine(spawnTile());
    }
}
