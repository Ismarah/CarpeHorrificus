using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler : MonoBehaviour
{

	public GameObject myDoor;
	bool jump = true;
	public AudioClip soundfile;
	public AudioClip music;
	AudioSource audioCLip;
	bool done;


	void Start ()
	{
		audioCLip = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (myDoor != null) {
			if (myDoor.GetComponent<CorpseDrawerScript> ().isOpen && Gamemanager.singleton.tapeCount == 2) {
				if (jump) {
					if (!done) {
						audioCLip.PlayOneShot (soundfile);
						done = true;
					}
					Gamemanager.singleton.StopMusic ();
					Gamemanager.singleton.PlayNewMusic (music);
					this.transform.position = Vector3.Lerp (this.transform.position, new Vector3 (this.transform.position.x, this.transform.position.y + 0.2f, this.transform.position.z - 2f), 1 * Time.deltaTime);
					this.GetComponent<Animator> ().SetBool ("jump", true);
					Invoke ("StopJump", 1.15f);
				}
		
			} else {
				jump = true;
			}
		}
	}

	void StopJump ()
	{
		this.GetComponent<Animator> ().SetBool ("jump", false);
		jump = false;
		Destroy (this.gameObject);
	}
}
