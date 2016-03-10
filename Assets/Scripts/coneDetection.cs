using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coneDetection : MonoBehaviour {

	public bool onSpot;
	public float energy = 100;

	public GameObject sliderX;

	Slider volumeSlider;

	// Use this for initialization
	void Start () {

	volumeSlider = sliderX.GetComponent<Slider>();

	
	}
	
	// Update is called once per frame
	void Update () {

		volumeSlider.value = energy;

		if (energy < 0) {
			Invoke ("lightWarm", 1.5f);
		}
			

		if (energy < 100 && energy >=2 ) {
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
			energy = 2;
		}
		
}
