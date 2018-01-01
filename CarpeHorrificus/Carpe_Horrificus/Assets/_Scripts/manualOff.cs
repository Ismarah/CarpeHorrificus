using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manualOff : MonoBehaviour
{

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			disableManual ();
		}
		
	}

	void disableManual ()
	{

		this.gameObject.SetActive (false);
	}
}
