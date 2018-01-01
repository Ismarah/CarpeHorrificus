using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
	public GvrReticlePointer pointer;

	void Update ()
	{
		if (!Gamemanager.singleton.crawlerSpawned) {
			RaycastHit hit;
			if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity)) {
				if (hit.collider.CompareTag ("Floor") && GetComponent<Animator> ().enabled == false) {
					pointer.GetComponent<MeshRenderer> ().materials [0].color = Color.green;

					//Debug.Log (hit.point);
					//Debug.Log ("Collider detected! 3D collider works!");
					if (Input.GetMouseButtonDown (0)) {
						this.transform.position = new Vector3 (hit.point.x, transform.position.y, hit.point.z);
					}
				} else {
					pointer.GetComponent<MeshRenderer> ().materials [0].color = Color.white;
				}
			}
		}

	}

}
