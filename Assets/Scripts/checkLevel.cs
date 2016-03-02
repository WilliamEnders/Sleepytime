using UnityEngine;
using System.Collections;

public class checkLevel : MonoBehaviour {

	public Light spotLight;
	public testPickUp script;

	void Start () {
		script = GameObject.Find("ThirdPersonController").GetComponent<testPickUp> ();
	}
	

	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if ((script.temp.transform.parent == null) && (script.inventory == 1)) {
			spotLight.color = Color.green;
			Destroy (other); //placeholder until we get other scenes
		}	
	}
}
