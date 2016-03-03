using UnityEngine;
using System.Collections;

public class characterMove : MonoBehaviour {

	public int speed;
	private Rigidbody rb;
	public bool jumping;
	private float x,y,z;
	private bool grounded;
	public Transform pivot;

	// Use this for initialization
	void Start () {
		jumping = false;
		rb = GetComponent<Rigidbody> ();
		y = rb.velocity.y;
	}
	
	// Update is called once per frame
	void Update () {
			float x = Input.GetAxis ("Horizontal") * speed;
			float z = Input.GetAxis ("Vertical") * speed;

		if(x != 0 || z != 0){
			transform.rotation = new Quaternion (0,pivot.rotation.y,0,0);
		}

		if (rb.velocity.y < 0.01f && rb.velocity.y > -0.01f) {
			grounded = true;
		}
			else {
			grounded = false;
		}
		if (grounded && Input.GetButtonDown ("Jump")) {
			y = 8;
			rb.velocity = new Vector3 (x, y, z);
		} else {
			rb.velocity = new Vector3 (x, rb.velocity.y, z);
		}
	}
}
