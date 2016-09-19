using UnityEngine;
using System.Collections;

public class Bally : MonoBehaviour {
    public float BallInitVel = 600f;
    private Rigidbody rb;
    private bool BallInPlay;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && BallInPlay == false) {
            transform.parent = null;
            BallInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(Random.Range(-1000, 1000), BallInitVel, 0));
        }
	}
}
