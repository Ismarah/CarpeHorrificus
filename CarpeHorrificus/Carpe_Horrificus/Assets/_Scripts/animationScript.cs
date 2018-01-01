using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScript : MonoBehaviour
{
	Animator animator;
	GameObject player;

	void Start ()
	{
		animator = GetComponent<Animator> ();
		player = this.gameObject;
	}

	void Update ()
	{
		//Debug.Log (Time.frameCount);
		if (player.transform.position == new Vector3 (-2.2f, 1.8f, -2)) {
			//animator.SetBool ("done", true);
			animator.enabled = false;
			Camera.main.GetComponent<GvrPointerPhysicsRaycaster> ().enabled = true;
			this.enabled = false;
			//Debug.Log ("set bool true");
		}
	}
}
