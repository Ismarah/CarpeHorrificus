using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoorSecondRow : MonoBehaviour
{

	bool done = false;
	public Vector3 closedState;
	Vector3 originalState;
	public GameObject crawler2;
	public GameObject zombie;


	void Start ()
	{
		originalState = this.transform.localEulerAngles;
	}

	void Update ()
	{
		if (!done) {
			if (Input.GetMouseButtonDown (0)) {
				Vector3 rotate = closedState;
				this.gameObject.transform.localEulerAngles = rotate;
				done = true;
			}
		}
	}

	public void OpenDoor ()
	{
		if (Gamemanager.singleton.playerHasKey) {
			transform.localEulerAngles = originalState;
			if (!Gamemanager.singleton.crawlerSpawned) {
				Instantiate (crawler2);
				Gamemanager.singleton.crawlerSpawned = true;
				Instantiate (zombie);
			}
		}
	}
}
