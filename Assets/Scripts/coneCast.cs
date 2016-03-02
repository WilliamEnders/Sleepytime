using UnityEngine;
using System.Collections;

public class coneCast : MonoBehaviour {

	public float rayDistance = 100;
	public Transform playerSpot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay (Collider other) {
		castRay ();
		if (other.CompareTag ("Player")) {
			
		}
	}


	void OnDrawGizmos() {
		Gizmos.color = Color.red;
		if (GameObject.Find ("cone").GetComponent<coneDetection> ().onSpot == true) {
			Gizmos.DrawRay (transform.position, playerSpot.position * rayDistance);
		}
	}


	void castRay() {
		RaycastHit hitInfo;
		if (Physics.Raycast (transform.position, playerSpot.position, out hitInfo)) {
			Debug.Log ("HIT:" + hitInfo.collider.name);
		}
	}

}
