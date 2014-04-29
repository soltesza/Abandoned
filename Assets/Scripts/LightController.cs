﻿using UnityEngine;
using System.Collections;
public class LightController : MonoBehaviour 
{
	public GameObject player;
	//The offset of the camera to centrate the player in the X axis
	public float offsetX = -5;
	//The offset of the camera to centrate the player in the Z axis
	public float offsetY = 3;
	//The offset of the camera to centrate the player in the Z axis
	public float offsetZ = 0;
	//The maximum distance permited to the camera to be far from the player, its used to     make a smooth movement
	public float maximumDistance = 2;
	//The velocity of your player, used to determine que speed of the camera
	public float playerVelocity = 10;
	
	private float movementX;
	private float movementY;
	private float movementZ;
	
	void Start () 
	{
		transform.position = new Vector3(player.transform.position.x + offsetX, transform.position.y, player.transform.position.z + offsetZ);
		transform.LookAt(player.transform);
	}
	
	// Update is called once per frame
	void Update () 
	{
		movementX = ((player.transform.position.x + offsetX - this.transform.position.x))/maximumDistance;
		movementY = ((player.transform.position.y + offsetY - this.transform.position.y))/maximumDistance;
		movementZ = ((player.transform.position.z + offsetZ - this.transform.position.z))/maximumDistance;
		this.transform.position += new Vector3((movementX * playerVelocity * Time.deltaTime), (movementY * playerVelocity * Time.deltaTime), (movementZ * playerVelocity * Time.deltaTime));
	}
}