using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorpseDrawerScript : MonoBehaviour
{
	public bool isOpen;
	public GameObject player;
	public float maxDistance;

	public AudioClip open;
	public AudioClip close;
	AudioSource audioClip;

	void Start ()
	{
		if (this.gameObject.transform.localEulerAngles != new Vector3 (0, 0, 0)) {
			isOpen = true;
		}
		audioClip = GetComponent<AudioSource> ();
	}

	public void OpenClose ()
	{
		if (!isOpen) {
			GetComponent<AudioSource> ().clip = open;
			audioClip.PlayOneShot (open);
			Vector3 rotate = new Vector3 (0, -90f, 0);
			this.gameObject.transform.localEulerAngles = rotate;
			isOpen = true;

		} else {
			GetComponent<AudioSource> ().clip = close;
			audioClip.PlayOneShot (close);
			Vector3 rotate = new Vector3 (0, 0, 0);
			this.gameObject.transform.localEulerAngles = rotate;
			isOpen = false;
		}
	}

	public void OpenCloseMonsterDoor ()
	{
		Vector3 distanceToPlayer = new Vector3 (player.transform.position.x - this.transform.position.x, player.transform.position.y - this.transform.position.z, player.transform.position.z - this.transform.position.z);
		float distance = distanceToPlayer.magnitude;
		if (!isOpen && distance <= maxDistance && Gamemanager.singleton.tapeCount == 2) {
			GetComponent<AudioSource> ().clip = open;
			audioClip.PlayOneShot (open);
			Vector3 rotate = new Vector3 (0, -90f, 0);
			this.gameObject.transform.localEulerAngles = rotate;
			isOpen = true;

		} else {
			GetComponent<AudioSource> ().clip = close;
			audioClip.PlayOneShot (close);
			Vector3 rotate = new Vector3 (0, 0, 0);
			this.gameObject.transform.localEulerAngles = rotate;
			isOpen = false;
		}
	}

}
