﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerChange : MonoBehaviour {

	public GameObject player1;
	public GameObject model;
	public float seconds;
	public float cooldown = 10;
	public Text text;
	public Slider slider;
	public bool canTransform = true;


	void Start () {
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.R) && canTransform == true) {
			player1.SetActive (false);
			model.SetActive (true);
			InvokeRepeating ("Countdown", 1.0f, 1);
			Invoke ("transformPlayer", 10);
			canTransform = false; 
		}
	}

	void Countdown(){
		print (seconds);
		seconds--;
		text.text = "Time Left:" + Mathf.Round (seconds);
	
		if (seconds <= 0) {
			CancelInvoke ("Countdown");
			player1.SetActive (true);
			model.SetActive (false);
			seconds = 5;
		}
	}

	void transformPlayer(){
		canTransform = true;
	}

	void coolDown(){
		if (canTransform == false) {
			cooldown--;
			slider.value = cooldown;
		} else {
			slider.value = 10f;		
		}
	
	}
}

