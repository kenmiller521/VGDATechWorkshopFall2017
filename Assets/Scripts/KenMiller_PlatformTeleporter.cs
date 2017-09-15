using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KenMiller_PlatformTeleporter : MonoBehaviour {
    public GameObject player;
    public float followOffset;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x-followOffset, player.transform.position.y, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Contains("Platform"))
        {
            collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x+9, collision.gameObject.transform.position.y,0);
        }
    }
}
