﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunningBoy : MonoBehaviour
{

    private bool midJump = false;

    public GameObject scoreText;
    int scoreCounter;

    public AudioSource jumpingAudio;
    public AudioSource collectingAudio;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,2.5f);
	scoreCounter = Int32.Parse(scoreText.GetComponent<Text>().text);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Time.deltaTime * Input.GetAxis("Horizontal"),0,0);

	if(this.transform.position.x > 0.55f)
  	    this.transform.position = new Vector3(0.55f, this.transform.position.y, this.transform.position.z);
 
	if(this.transform.position.x < -0.55f)
  	    this.transform.position = new Vector3(-0.55f, this.transform.position.y, this.transform.position.z);

	if(Input.GetKey("space") && !midJump){
	    jumpingAudio.Play();
	    GetComponent<Rigidbody>().velocity = new Vector3(0,0.5f,2.5f);
	    midJump = true;
	    StartCoroutine(stopJump());
	}
    }

    IEnumerator stopJump(){
	yield return new WaitForSeconds(0.55f);
	GetComponent<Rigidbody>().velocity = new Vector3(0,-0.5f,2.5f);
	yield return new WaitForSeconds(0.55f);
	GetComponent<Rigidbody>().velocity = new Vector3(0,0,2.5f);
	midJump = false;
    }

    private void OnTriggerEnter(Collider otherObject){
	if (otherObject.tag == "obstacle"){
	    scoreCounter = Int32.Parse(scoreText.GetComponent<Text>().text);
	    scoreCounter -= 50000;
	    scoreText.GetComponent<Text>().text = scoreCounter.ToString();
	} else if (otherObject.tag == "gem"){
	    collectingAudio.Play();
	    Destroy(otherObject.gameObject);
	    scoreCounter = Int32.Parse(scoreText.GetComponent<Text>().text);
	    scoreCounter += 250;
	    scoreText.GetComponent<Text>().text = scoreCounter.ToString();
	}
    }
}
