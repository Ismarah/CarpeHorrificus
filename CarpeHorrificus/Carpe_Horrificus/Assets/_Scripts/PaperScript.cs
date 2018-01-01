using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperScript : MonoBehaviour
{
	public bool isUp;
	public GameObject player;
	public Vector3 rotateUp;
	public float distance;
	public float distanceZ;
	public Vector3 deskPos;
	public Vector3 deskRot;
	public bool onDesk;
	public float deskUpDistance;

	public AudioClip soundfile;
	AudioSource audioCLip;


	void Start ()
	{
		audioCLip = GetComponent<AudioSource> ();
	}

	public void PickUp ()
	{
		if (!isUp && !onDesk) {
			Vector3 newPosUp = new Vector3 (player.transform.position.x + distance, player.transform.position.y, player.transform.position.z + distanceZ);
			this.gameObject.transform.position = newPosUp;
			this.gameObject.transform.eulerAngles = rotateUp;
			audioCLip.PlayOneShot (soundfile);
			isUp = true;
		} else if (isUp) {
			this.gameObject.transform.position = deskPos;
			this.gameObject.transform.eulerAngles = deskRot;
			isUp = false;
			onDesk = true;
		} else if (!isUp && onDesk) {
			Vector3 newPosUp = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z - deskUpDistance);
			this.gameObject.transform.position = newPosUp;
			this.gameObject.transform.eulerAngles = new Vector3 (90, 0, 0);
			isUp = true;
		}
	}
}
