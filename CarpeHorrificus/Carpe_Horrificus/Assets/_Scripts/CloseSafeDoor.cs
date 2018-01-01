using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSafeDoor : MonoBehaviour
{



	public void CloseDoor ()
	{
		if (!(transform.localEulerAngles == new Vector3 (0, 0, 0))) {
			//is open
			transform.localEulerAngles = new Vector3 (0, 0, 0);
		}
	}
}
