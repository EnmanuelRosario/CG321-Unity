﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public float ballInitialVel = 600f;
    private Rigidbody rb;
    private bool ballInPlay;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        ballInPlay = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("Fire1") && ballInPlay == false) {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(Random.Range(-1000, 1000), ballInitialVel, 0));
            
        }
	}
}
