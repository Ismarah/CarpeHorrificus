using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wackeln : MonoBehaviour
{
	Animator animator;
	bool doOnce = true;

	public AudioClip soundfile;
	AudioSource audioClip;

	bool doOnce2;

	void Start ()
	{
		animator = GetComponent<Animator> ();
		audioClip = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (Gamemanager.singleton.tapeCount == 2 && doOnce) {
			animator.SetBool ("wackeln", true);
			if (!doOnce2) {
				audioClip.Play ();
				doOnce2 = true;
			}

		}
		if (GetComponent<CorpseDrawerScript> ().isOpen && doOnce) {
			animator.SetBool ("wackeln", false);
			audioClip.Stop ();
			doOnce = false;
		}
	}
}
