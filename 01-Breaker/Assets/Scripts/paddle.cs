using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {
    public float paddleSpeed;
    private Vector3 PlayerPos = new Vector3(0, -3.5f, 0);
   

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        PlayerPos = new Vector3(Mathf.Clamp(xPos, -10f, 10f), -3.5f, 0f);
        transform.position = PlayerPos;
	}
}
