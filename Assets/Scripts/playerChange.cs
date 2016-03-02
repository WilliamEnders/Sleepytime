using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerChange : MonoBehaviour {

	public GameObject player1;
	public GameObject model;
	public float seconds;
	public float cooldown;
	public Text text;
	public Text text2;
	public bool canTransform = true;


	void Start () {
		player1 = player1;
		model = model;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.R) && canTransform == true) {
			player1.SetActive (false);
			model.SetActive (true);
			InvokeRepeating ("Countdown", 1.0f, 1);
			Invoke ("transformPlayer", 10);
			canTransform = false; 
			coolDown ();
		}
		if (canTransform == false) {
			InvokeRepeating ("coolDown", 5f, 1f);
		
		}
	}

	void Countdown(){
		//print (seconds);
		seconds --;
		text.text = "Time Left:" + Mathf.Round (seconds);
	
		if (seconds <= 0f) {
			CancelInvoke ("Countdown");
			player1.SetActive (true);
			model.SetActive (false);
			seconds = 5f;
		}
	}

	void transformPlayer(){
		canTransform = true;
	}

	void coolDown(){
		cooldown--;
		text2.text = "Change Time:" + Mathf.Round (cooldown);
		print (cooldown);

		if (cooldown <= 0f) {
			CancelInvoke ("coolDown");
			cooldown = 10f;
		}
	
	}
		
}

