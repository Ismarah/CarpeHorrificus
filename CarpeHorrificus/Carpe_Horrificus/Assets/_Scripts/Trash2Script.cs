using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash2Script : MonoBehaviour
{
	public GameObject paper1;
	public GameObject paper2;
	public Vector3 fallDownPos;
	public Vector3 fallDownRot;

	public AudioClip soundFile;
	AudioSource audioClip;
	bool done;

	void Start ()
	{
		audioClip = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (paper1.GetComponent<PaperScript> ().isUp) {
			if (!done) {
				audioClip.PlayOneShot (soundFile);
				done = true;
			}
			this.transform.localPosition = fallDownPos;
			this.transform.localEulerAngles = fallDownRot;
			paper2.SetActive (true);
		}
	}
}
