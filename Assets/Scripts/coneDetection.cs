using UnityEngine;
using System.Collections;

public class coneDetection : MonoBehaviour {

	public bool onSpot;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Mouse0)) {
			GetComponent<MeshCollider> ().enabled = true;
			//TAKE THIS OFF LATER
			GameObject.Find ("LIGHT").GetComponent<Light> ().enabled = true;
		} else {
			GetComponent<MeshCollider> ().enabled = false;
			onSpot = false;
			//TAKE THIS OFF LATER
			GameObject.Find ("LIGHT").GetComponent<Light> ().enabled = false;
		}


	}

	void OnTriggerStay (Collider other){
		//print (other);
		if (other.CompareTag ("Player")) {
			onSpot = true;
		} 
	}

	void OnTriggerExit (Collider other) {
		if (other.CompareTag ("Player")) {
			onSpot = false;
		}
	}
		
}
