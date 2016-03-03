using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testPickUp : MonoBehaviour {

	public GameObject player;
	public GameObject temp;
	public int inventory = 0;


	void Start () {
		player = player;
		temp = null;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && temp != null) {
			if (temp.transform.parent == null) {
				temp.transform.parent = transform;
				inventory++;
			} else if (temp.transform.parent == transform) {
				temp.transform.parent = null;
			}
		}
	}

	void OnTriggerStay(Collider other){

		if (other.gameObject.tag == "Toy") {
			if (Input.GetKeyDown (KeyCode.E)) {
				temp = other.gameObject;
				print ("wow");
			}
		}	
	}
}
