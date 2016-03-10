using UnityEngine;
using System.Collections;

public class coneDetection : MonoBehaviour {

	public bool onSpot;
	public int energy = 100;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		if (energy < 0) {
			Invoke ("lightWarm", 1.5f);
		}
			

		if (energy < 100 && energy >= 0) {
			energy += 1;
		}


		if (Input.GetKey(KeyCode.Mouse0) && energy > 0) {
			energy -= 6;
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

		void lightWarm () {
			energy = 1;
		}
		
}
