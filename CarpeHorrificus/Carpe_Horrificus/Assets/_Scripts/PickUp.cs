using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
	public bool isUp = false;
	public GameObject player;
	public Vector3 rotateUp;
	public Vector3 rotateDown;
	//public Vector3 newPos;
	public float distanceX;
	public float distanceY;
	public float distanceZ;
	Vector3 originalPos;


	void Start ()
	{
		originalPos = this.transform.localPosition;
	}



	public void OnClick ()
	{
		if (!isUp) {
			Vector3 newPosUp = new Vector3 (player.transform.position.x - distanceX, player.transform.position.y - distanceY, player.transform.position.z - distanceZ);
			this.gameObject.transform.localPosition = newPosUp;
			this.gameObject.transform.localEulerAngles = rotateUp;
			isUp = true;
		} else {
			this.gameObject.transform.localPosition = originalPos;
			this.gameObject.transform.localEulerAngles = rotateDown;
			isUp = false;
		}
	}
}
