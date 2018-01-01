using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapeRecorder : MonoBehaviour
{
	public GameObject tape1;
	public GameObject tape2;
	public GameObject tape3;
	GameObject[] tapes;
	HashSet<GameObject> heardTapes;
	public GameObject button;
	bool tapeInside;
	GameObject currTapeInside;
	AudioSource audioClip;
	AudioClip soundFile;

	void Start ()
	{
		tapes = new GameObject[3]{ tape1, tape2, tape3 };
		heardTapes = new HashSet<GameObject> ();
		audioClip = GetComponent<AudioSource> ();
	}

	public void PlayTape ()
	{
		if (!tapeInside) {
			foreach (GameObject tape in tapes) {
				if (tape.GetComponent<TapeScript> ().hearable && tape.GetComponent<TapeScript> ().isUp) {
					//play tape sound
					audioClip.clip = tape.GetComponent<TapeScript> ().GetSoundFile ();
					soundFile = tape.GetComponent<TapeScript> ().GetSoundFile ();
					audioClip.PlayOneShot (soundFile);
					tape.transform.position = new Vector3 (-3.2744f, 1.096f, -3.1651f);
					tape.transform.eulerAngles = new Vector3 (0, 37.61f, 0);
					button.transform.localEulerAngles = new Vector3 (19.6f, 0, 0);
					if (!heardTapes.Contains (tape)) {
						heardTapes.Add (tape);
					}
					Debug.Log (heardTapes.Count);
					Gamemanager.singleton.tapeCount = heardTapes.Count;
					tapeInside = true;
					currTapeInside = tape;
				}
			}
		} else {
			foreach (GameObject tape in tapes) {
				if (tape == currTapeInside) {
					audioClip.Stop ();
					button.transform.localEulerAngles = new Vector3 (0, 0, 0);
					currTapeInside.transform.position = tape.GetComponent<TapeScript> ().deskPos;
					currTapeInside.transform.eulerAngles = tape.GetComponent<TapeScript> ().deskRot;
					tape.GetComponent<TapeScript> ().isUp = false;
					tapeInside = false;
				}
			}
		}
	}
}
