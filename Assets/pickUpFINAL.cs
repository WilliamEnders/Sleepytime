using UnityEngine;
using System.Collections;

public class pickUpFINAL : MonoBehaviour {

	public GameObject temp;
	public bool canPickup;
	public Collider tempCol;

	// Use this for initialization
	void Start () {
		temp = null;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && canPickup && temp == null) {
			tempCol.transform.parent = transform;
			temp = tempCol.gameObject;
			tempCol = null;
		}
		else if (Input.GetKeyDown (KeyCode.E) && temp != null) {
			temp.transform.parent = null;
			tempCol = null;
			temp = null;
		}
	}

	void OnTriggerEnter(Collider info){
		if (info.CompareTag ("Toy")) {
			canPickup = true;
			tempCol = info;
		}
	}
	void OnTriggerExit(Collider info){
		if (info.CompareTag ("Toy")) {
			canPickup = false;
			tempCol = null;
		}
	}

}
