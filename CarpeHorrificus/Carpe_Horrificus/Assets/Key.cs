using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	public GameObject player;
	public bool isUp;
	public Vector3 deskPos;
	public Vector3 deskRot;
	public bool onDesk;
	public float deskUpDistance;

	public void PickUp ()
	{
		
		if (isUp) {
			this.gameObject.transform.localPosition = deskPos;
			this.gameObject.transform.localEulerAngles = deskRot;
			isUp = false;
			onDesk = true;
		} else {
			Vector3 newPosUp = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z - deskUpDistance);
			this.gameObject.transform.position = newPosUp;
			this.gameObject.transform.eulerAngles = new Vector3 (90, 0, 0);
			isUp = true;
		}
	}
}
