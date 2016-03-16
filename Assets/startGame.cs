using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {

	private bool once;
	public ScreenFader fade;
	public int num;
	// Use this for initialization
	void Start () {
		once = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return) && once){
			
			once = false;
		}
		if(!once){
			fade.EndScene (num);
		}
	}
}
