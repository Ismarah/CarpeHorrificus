using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNumberPad : MonoBehaviour
{

	public GameObject pad;

	public void ActivateInput ()
	{
		if (Gamemanager.singleton.tapeCount == 2) {
			pad.SetActive (true);
		}
	}
}
