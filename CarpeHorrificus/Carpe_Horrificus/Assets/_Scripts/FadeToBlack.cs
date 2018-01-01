using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToBlack : MonoBehaviour
{

	CanvasGroup canvasGroup;

	void Start ()
	{
		canvasGroup = GetComponent<CanvasGroup> ();
		canvasGroup.alpha = 0;
	}

	void Update ()
	{
		if (canvasGroup.alpha != 1)
			canvasGroup.alpha += 0.7f * Time.deltaTime;
	}
}
