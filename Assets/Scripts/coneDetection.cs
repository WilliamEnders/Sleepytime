using UnityEngine;

public class coneDetection : MonoBehaviour {

	public bool onSpot;
	public float energy = 100;
	public bool full;



	// Use this for initialization
	void Start () {

		full = true;

	
	}
	
	// Update is called once per frame
	void Update () {

		if (energy <= 0) {
			Invoke ("lightWarm", 2);
			full = false;
		}
			

		if (energy < 100 && full == true) {
			energy += 0.4f;
		}


		if (Input.GetKey(KeyCode.Mouse0) && energy > 0) {
			energy -= 2;
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
		full = true;	
		if (energy < 100 && full == true) {
			energy += 0.4f;
		}
		}
		
}
