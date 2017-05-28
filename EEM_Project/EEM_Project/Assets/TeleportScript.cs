using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
	public LineRenderer lineRenderer;

	void Update ()
	{
		RaycastHit hit;
		if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity)) {
			if (hit.collider.CompareTag ("Floor")) {

				lineRenderer.SetPosition (0, transform.position);
				lineRenderer.SetPosition (1, hit.point);

				//Debug.Log (hit.point);
				//Debug.Log ("Collider detected! 3D collider works!");
				if (Input.GetMouseButtonDown (0)) {
					this.transform.position = new Vector3 (hit.point.x, transform.position.y, hit.point.z);
				}
			}
		}
	}

	public void Teleport ()
	{
		Debug.Log ("Teleport");
		Vector3 direction = Random.onUnitSphere;
		direction.y = Mathf.Clamp (direction.y, 0.5f, 1f);
		transform.localPosition = direction;
	}

}
