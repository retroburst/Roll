﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb = null;
	public float Speed = 0.0f;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
	
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 move = new Vector3 (moveHorizontal, 0, moveVertical);
		rb.AddForce (move * Speed * Time.deltaTime);

	}
}