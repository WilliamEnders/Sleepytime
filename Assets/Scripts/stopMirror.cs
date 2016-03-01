using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

public class stopMirror : MonoBehaviour {
	IEnumerator Start ()
	{
		yield return new WaitForEndOfFrame ();
		UnityEngine.VR.VRSettings.showDeviceView = false;
	}
}
