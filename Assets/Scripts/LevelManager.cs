﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public GameObject currentCheckPoint;
	private PlayerController player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void RespawnPlayer()
	{
		Debug.Log ("Player respawn");
		player.transform.position = currentCheckPoint.transform.position;
	}
}
