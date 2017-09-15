using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WOlfgangHellicksonSabelhaus_PlatformTeleporter : MonoBehaviour {

	public GameObject player;
	public float followOffset;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3 (player.transform.position.x - followOffset, player.transform.position.y, 0);

	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.name.Contains("Platform"))
		{
			collision.transform.position = new Vector3 (collision.transform.position.x + 9, collision.transform.position.y, collision.transform.position.z);
		}
	}
}
