using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDestroy : MonoBehaviour
{

	void Update ()
	{
		if (Gamemanager.singleton.tapeCount == 3) {
			Destroy (this.gameObject);
		}
	}
}
