using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{

	bool done = false;
	public Vector3 closedState;
	Vector3 originalState;

	public AudioClip soundfile;
	public AudioClip soundfile2;
	AudioSource audioCLip;

	bool done2;

	void Start ()
	{
		originalState = this.transform.localEulerAngles;
		audioCLip = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (!done) {
			if (Input.GetMouseButtonDown (0)) {
				Vector3 rotate = closedState;
				this.gameObject.transform.localEulerAngles = rotate;
				audioCLip.PlayOneShot (soundfile);
				done = true;
			}


		}
		if (Gamemanager.singleton.tapeCount == 3) {
			transform.localEulerAngles = originalState;
			GetComponent<AudioSource> ().clip = soundfile2;
			if (!done2) {
				audioCLip.PlayOneShot (soundfile2);
				done2 = true;
			}
			//Invoke ("StopMusic", 1);
		}
	}

	void StopMusic ()
	{
		audioCLip.Stop ();
	}
}
