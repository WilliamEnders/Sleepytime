using UnityEngine;
using System.Collections;

public class testPickup : MonoBehaviour {

	public GameObject cube;
	private GameObject temp;

	// Use this for initialization
	void Start () {
	
	}

	void Update (){
		if(Input.GetKeyDown(KeyCode.Space)){
			
			temp = cube;
			if (temp.transform.parent == null) {
				temp.transform.parent = transform;
			} else if (temp.transform.parent == transform) {
				temp.transform.parent = null;
				temp = null;
			}
		}

	}

}
