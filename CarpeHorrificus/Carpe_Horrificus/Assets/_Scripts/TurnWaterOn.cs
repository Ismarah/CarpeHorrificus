using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnWaterOn : MonoBehaviour
{
	public GameObject waterJet;
	public GameObject waterInSink;
	public GameObject waterObject;
	bool doOnce = true;

	void Update ()
	{
		if (Gamemanager.singleton.tapeCount == 1 && this.GetComponent<PickUp> ().isUp && doOnce) {
			waterObject.GetComponent<WaterOnOff> ().WaterOff ();
			waterJet.SetActive (true);
			waterInSink.SetActive (true);
			doOnce = false;
		}
	}
}
