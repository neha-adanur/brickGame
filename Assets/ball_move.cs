using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour {

	public float force;
	public Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce (new Vector2 (1f, 0.5f) * Time.deltaTime * force);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
