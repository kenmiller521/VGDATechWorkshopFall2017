using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuanNguyen_Teleporter : MonoBehaviour {
    public GameObject player;
    public float followOffset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Platform"))
        {

        }
    }
}
