using UnityEngine;
using System.Collections;

public class checkLevel : MonoBehaviour {

	public testPickUp script;

	void Start () {
		script = GameObject.Find("ThirdPersonController").GetComponent<testPickUp> ();
	}
	

	void Update () {
	
	}
	void OnTriggerStay(Collider other){
		if (other.tag == "Toy") {
			if ((script.inventory == 1)) {
				Destroy (script.temp); //placeholder until we get other scenes
			}
		}
	}
}
