using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePaper1 : MonoBehaviour
{

	bool doOnce = true;
	public GameObject paper1;

	void Start ()
	{
		
	}

	void Update ()
	{
		if (this.GetComponent<CorpseDrawerScript> ().isOpen && doOnce) {
			paper1.SetActive (true);
			doOnce = false;
			Destroy (this.GetComponent<InstantiatePaper1> ());
		}
	}
}
