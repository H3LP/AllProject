using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mauseLooking : MonoBehaviour {
	float maximumX = -20f;
	float minimumX = 20f;
	float rotY;
	float rotX;
	public float speed;
	// Use this for initialization
	void Start () {
		

		
	}
	
	// Update is called once per frame
	void Update () {

		rotY += Input.GetAxis("Mouse Y");
		rotX += Input.GetAxis("Mouse X");

		
		
		transform.localRotation = Quaternion.Euler(rotX, rotY, z: 0);

		
	}
}
