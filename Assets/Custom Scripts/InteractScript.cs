﻿using UnityEngine;
using System.Collections;

public class InteractScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp("e")) {
			Debug.Log("You interacted!");
		}
	}
}
