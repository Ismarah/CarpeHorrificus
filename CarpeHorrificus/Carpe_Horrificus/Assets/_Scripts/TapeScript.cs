using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapeScript : MonoBehaviour
{

	public bool isUp;
	public GameObject player;
	public Vector3 rotateUp;
	public float distance;
	public Vector3 deskPos;
	public Vector3 deskRot;
	public bool hearable;
	public float deskUpDistance;

	public AudioClip soundFile;

	public void PickUp ()
	{
		if (!isUp && !hearable) {
			Vector3 newPosUp = new Vector3 (player.transform.position.x + distance, player.transform.position.y, player.transform.position.z);
			this.gameObject.transform.position = newPosUp;
			this.gameObject.transform.eulerAngles = rotateUp;
			isUp = true;
		} else if (isUp) {
			this.gameObject.transform.position = deskPos;
			this.gameObject.transform.eulerAngles = deskRot;
			isUp = false;
			hearable = true;
		} else if (!isUp && hearable) {
			Vector3 newPosUp = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z - deskUpDistance);
			this.gameObject.transform.position = newPosUp;
			this.gameObject.transform.eulerAngles = new Vector3 (90, 0, 0);
			isUp = true;
		}

	}


	public AudioClip GetSoundFile ()
	{
		return soundFile;
	}



}
