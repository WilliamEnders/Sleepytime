﻿using UnityEngine;
using System.Collections;

public class coneCast : MonoBehaviour {

	public Transform playerSpot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.LookAt (playerSpot);
	
	}

	void OnTriggerStay (Collider other) {
		castRay ();
		if (other.CompareTag ("Player")) {
			
		}
	}


	void castRay() {
		RaycastHit hitInfo;
		if (Physics.Raycast (transform.position, transform.forward, out hitInfo)) {
			if (hitInfo.collider.CompareTag ("Player")) {
				//Debug.Log ("HIT:" + hitInfo.collider.name);
				if (GameObject.Find ("cone").GetComponent<coneDetection> ().onSpot == true) {
					print ("i see you");
				}
			}
		}
	}

}
