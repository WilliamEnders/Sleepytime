using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerChange : MonoBehaviour {

	public GameObject player;
	public GameObject model;

	public bool canTransform;
	public bool quickBack;

	public Mesh mesh;
	public Mesh noMesh;


	void Start () {

		canTransform = true;
		quickBack = false;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.R) && canTransform == true) {
			player.SetActive (false);
			model.GetComponent<MeshFilter> ().mesh = mesh;
			canTransform = false; 
			quickBack = false;
			Invoke ("goBack", 0.5f);
			Invoke ("transformPlayer", 10);
			Invoke ("afterWhile", 9);
		}

		if (Input.GetKeyDown (KeyCode.R) && canTransform == false && quickBack == true){
			player.SetActive (true);
			model.GetComponent<MeshFilter> ().mesh = noMesh;
		}

	}

	void goBack(){

		quickBack = true;
		
	}

	void transformPlayer(){
		canTransform = true;
	}

	void afterWhile() {
		model.GetComponent<MeshFilter> ().mesh = noMesh;
		player.SetActive (true);
	}

		
}

