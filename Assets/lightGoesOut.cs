using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lightGoesOut : MonoBehaviour {

	private coneDetection cone;
	private bool off;
	private bool once;
	public Text txt;

	// Use this for initialization
	void Start () {
		once = false;
		off = false;
		cone = GameObject.Find ("cone").GetComponent<coneDetection> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(cone.energy <= 0){
			off = true;
		}
		if(off && !once){
			once = true;
			txt.text += "\n Well, it's a little low on battery. Give it a second to charge.";
		}
	}
}
