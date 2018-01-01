using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
	public GameObject leftSink;
	public GameObject zombieRig2;
	bool doOnce;

	void Start ()
	{
		doOnce = true;
	}

	void Update ()
	{
		if (Gamemanager.singleton.safePinComplete && !leftSink.GetComponent<WaterOnOff> ().isOn && doOnce) {
			Destroy (this.gameObject);
			Instantiate (zombieRig2);
			doOnce = false;
		}
	}
}
