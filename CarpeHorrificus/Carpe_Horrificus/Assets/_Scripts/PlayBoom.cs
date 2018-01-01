using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBoom : MonoBehaviour
{

	public AudioClip soundfile;
	AudioSource audioClip;
	public GameObject myDoor;

	bool done;

	void Start ()
	{
		audioClip = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (myDoor.GetComponent<CorpseDrawerScript> ().isOpen && Gamemanager.singleton.tapeCount == 2 && !done) {
			audioClip.PlayOneShot (soundfile);
			done = true;
		}
	}
}
