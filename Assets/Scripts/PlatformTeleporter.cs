using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTeleporter : MonoBehaviour {
    public GameObject player;
    public float offset;
    private float rand;
    private GameObject[] platformLocations;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        platformLocations = GameObject.FindGameObjectsWithTag("PlatformLocation");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x + offset, player.transform.position.y, -10);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
        {
            collision.transform.position = platformLocations[Random.Range(0, platformLocations.Length)].GetComponent<Transform>().position;
            for(int i = 0; i < platformLocations.Length; i++)
            {
                platformLocations[i].GetComponent<Transform>().position = new Vector3(platformLocations[i].GetComponent<Transform>().position.x + 2, platformLocations[i].GetComponent<Transform>().position.y, 0);
            }
        }
    }
}
