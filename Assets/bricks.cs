using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour {

	public UIManager ui;
	void Start () {
		ui = GameObject.FindWithTag ("ui").GetComponent<UIManager>(); //access the UIManager script from the game object tagged with tag "ui"
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "ball") {
			ui.inc_score ();
			Destroy (gameObject);
		}
	}
}
