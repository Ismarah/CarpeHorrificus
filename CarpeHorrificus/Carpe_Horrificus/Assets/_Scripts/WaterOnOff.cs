using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterOnOff : MonoBehaviour
{

	public GameObject waterJet;
	public GameObject waterInSink;
	public bool isOn = false;
	public AudioClip soundfile;
	AudioSource audioCLip;

	public void Start ()
	{
		audioCLip = GetComponent<AudioSource> ();
	}

	public void WaterOff ()
	{
		if (!isOn) {
			waterJet.SetActive (true);
			waterInSink.SetActive (true);
			audioCLip.PlayOneShot (soundfile);
			isOn = true;

		} else if (isOn) {
			waterJet.SetActive (false);
			waterInSink.SetActive (false);
			audioCLip.Stop ();
			isOn = false;
		}
	}
}