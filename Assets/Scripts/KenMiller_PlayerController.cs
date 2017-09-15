using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KenMiller_PlayerController : MonoBehaviour {
    private Rigidbody2D rb2d;
    public int jumpStrength;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb2d.AddForce(new Vector3(1,0,0));
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(new Vector3(0, 1*jumpStrength, 0));
        }
	}
}
