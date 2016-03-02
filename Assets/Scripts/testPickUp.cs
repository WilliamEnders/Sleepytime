using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testPickUp : MonoBehaviour {

	public GameObject player;
	public GameObject temp;
	public int inventory = 0;


	void Start () {
		player = player;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {
			if (temp.transform.parent == null) {
				temp.transform.parent = player.transform;
				inventory++;
			} else if (temp.transform.parent == player.transform) {
				temp.transform.parent = null;
			}
		}
	}

	void OnTriggerStay(Collider other){

		if (other.gameObject.tag == "Toy") {
			if (Input.GetKeyDown (KeyCode.E)) {
				temp = other.gameObject;
			}
		}	
	}
}
