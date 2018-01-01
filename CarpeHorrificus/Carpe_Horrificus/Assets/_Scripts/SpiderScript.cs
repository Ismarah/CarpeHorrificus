using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderScript : MonoBehaviour
{
	public GameObject tape;
	Animator animator;

	public AudioClip soundfile;
	AudioSource audioCLip;


	void Start ()
	{
		animator = GetComponent<Animator> ();
		audioCLip = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (tape.GetComponent<TapeScript> ().isUp) {
			if (!audioCLip.isPlaying)
				audioCLip.PlayOneShot (soundfile);
			animator.SetBool ("walk", true);
			animator.SetBool ("away", true);
			if (transform.position == new Vector3 (-1.944f, 0, 1.524f)) {
				Destroy (this.gameObject);
			}
		}
	}
}
