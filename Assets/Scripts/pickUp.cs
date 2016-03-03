using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pickUp : MonoBehaviour {

	int inventory; 
	public Text text;
	public GameObject greenLightLOL;


	void Start(){
		inventory = 0;
	}

	void Update(){
	
	
	}

	void OnTriggerStay(Collider other){

		if (other.gameObject.tag == "Toy") {
			if (Input.GetKeyDown (KeyCode.E)) {
				Destroy (other.gameObject);
				inventory++;
				print (inventory);
				text.text = "Inventory:" + (inventory);
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if ((greenLightLOL) && inventory == 1) {
			Destroy (gameObject);
		}
	}
}

