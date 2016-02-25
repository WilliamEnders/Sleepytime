using UnityEngine;
using System.Collections;

public class moveBall : MonoBehaviour {

	private Rigidbody rb;
	public int speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal2") * speed;
		float z = Input.GetAxis ("Vertical2") * speed;
		rb.velocity = new Vector3 (x,0,z);
	}

}
