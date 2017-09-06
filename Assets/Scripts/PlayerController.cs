using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float movementSpeed = 1;
    public float jumpStr = 1;
    private Rigidbody2D rb2d;
    
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb2d.AddForce(new Vector2(movementSpeed, 0));
		if(Input.GetKeyDown(KeyCode.W))
        {
            rb2d.AddForce(new Vector2(0, jumpStr));
        }
	}
}
