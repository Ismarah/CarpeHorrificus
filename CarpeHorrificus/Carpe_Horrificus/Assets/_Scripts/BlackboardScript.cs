using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackboardScript : MonoBehaviour
{
	public GameObject leftSink;

	public AudioClip soundFile;
	AudioSource audioClip;

	bool done;

	void Start ()
	{
		audioClip = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (Gamemanager.singleton.safePinComplete && !leftSink.GetComponent<WaterOnOff> ().isOn) {
			if (!done) {
				audioClip.PlayOneShot (soundFile);
				done = true;
			}
			this.gameObject.transform.position = new Vector3 (-3.433f, 0, 0.29f);
			this.gameObject.transform.eulerAngles = new Vector3 (-33.67f, 89.858f, 0);
		}
	}
}
