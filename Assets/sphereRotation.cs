using UnityEngine;
using System.Collections;

public class sphereRotation : MonoBehaviour
{
	void Update(){
		transform.parent.Rotate (0,Input.GetAxis("Horizontal"),0);
	}
}