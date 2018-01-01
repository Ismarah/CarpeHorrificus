using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schiebetuer : MonoBehaviour
{
	bool openLeft = false;
	bool openRight = false;
	Vector3 originalPos;

	void Start ()
	{
		originalPos = this.transform.localPosition;
	}

	public void OnClickLeftDoor ()
	{
		if (!openLeft) {
			Vector3 newPos = new Vector3 (originalPos.x - 0.5f, originalPos.y, originalPos.z);
			this.gameObject.transform.localPosition = newPos;
			openLeft = true;
		} else {
			Vector3 newPos = new Vector3 (originalPos.x, originalPos.y, originalPos.z);
			this.gameObject.transform.localPosition = newPos;
			openLeft = false;
		}
	}

	public void OnClickRightDoor ()
	{
		if (!openRight && !openLeft) {
			Vector3 newPos = new Vector3 (originalPos.x + 0.5f, originalPos.y, originalPos.z);
			this.gameObject.transform.localPosition = newPos;
			openRight = true;
		} else {
			Vector3 newPos = new Vector3 (originalPos.x, originalPos.y, originalPos.z);
			this.gameObject.transform.localPosition = newPos;
			openRight = false;
		}
	}

}
