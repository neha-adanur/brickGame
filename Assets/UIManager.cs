using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	int score=0;
	public Text var;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void inc_score()
	{
		score++;
		var.text = "SCORE: " + score;
	}
}
