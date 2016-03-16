using UnityEngine;
using System.Collections;

public class dropOffZone : MonoBehaviour {

	public int toyCount;
	private pickUpFINAL player;
	public ScreenFader fade;

	// Use this for initialization
	void Start () {
		toyCount = 0;
		player = GameObject.Find ("ThirdPersonController").GetComponent<pickUpFINAL> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(toyCount == 3){
			fade.EndScene (2);
		}
	}

	void OnTriggerStay(Collider info){
		if(!player.canPickup){
			if(info.CompareTag("Toy")){
			Destroy (info.gameObject);
			toyCount++;
		}
	}
	}
}
