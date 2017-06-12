using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	Vector2 pos;
	public float speed;
	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	float movex=Input.GetAxis ("Horizontal");
		pos.x += movex * Time.deltaTime * speed;
		pos.x = Mathf.Clamp (pos.x, -8.4f, +8.4f);
		transform.position = pos;
	}
}
