﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    private GameObject player;
    public float followDistance;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x+ followDistance, player.transform.position.y, -10);
	}
}
