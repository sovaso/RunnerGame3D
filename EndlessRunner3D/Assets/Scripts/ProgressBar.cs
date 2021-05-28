using System;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    public int maximum;
    public Image mask;
    public GameObject scoreText;
    int scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        scoreCounter = Int32.Parse(scoreText.GetComponent<Text>().text);
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounter = Int32.Parse(scoreText.GetComponent<Text>().text);
	scoreCounter = Mathf.Clamp(scoreCounter, 0, maximum);
	float fillAmount = (float)scoreCounter / (float)maximum;
	mask.fillAmount = fillAmount;
    }
}
