using UnityEngine;
using System.Collections;

public class WaterCol : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ball")
        {
            Debug.Log("Collision Entered");
            Destroy(col.gameObject);
            GM.instance.LoseLife();
        }
    }
}
