﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidLi_CameraFollow : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}




	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, 0);

	}
}
