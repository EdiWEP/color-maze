﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTotalScore : MonoBehaviour {

    private Text scoreText;

	void Start () {
        scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + GameManager.score.ToString();
	}
	
}
