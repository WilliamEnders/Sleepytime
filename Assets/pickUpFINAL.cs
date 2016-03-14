using UnityEngine;
using System.Collections;
using Rewired;
[RequireComponent(typeof(CharacterController))]
public class pickUpFINAL : MonoBehaviour {

	public GameObject temp;
	public bool canPickup;
	public Collider tempCol;
	public int playerId = 0; // The Rewired player id of this character
	private Player player; // The Rewired Player


	// Use this for initialization
	void Start () {
		temp = null;
		player = ReInput.players.GetPlayer(playerId);
	}
	
	// Update is called once per frame
	void Update () {
		if (player.GetButtonDown("Action") && canPickup && temp == null) {
			tempCol.transform.parent = transform;
			Destroy (tempCol.transform.GetComponent<Rigidbody> ());
			temp = tempCol.gameObject;
			tempCol = null;

		}
		else if (player.GetButtonDown("Action") && temp != null) {
			temp.transform.parent = null;
			temp.gameObject.AddComponent <Rigidbody>();
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
