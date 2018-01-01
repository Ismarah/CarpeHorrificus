using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeScript : MonoBehaviour
{
	string safeCode = "8270";
	string inputUser;
	public GameObject safeDoor;

	public AudioClip soundFile;
	AudioSource audioClip;

	void Start ()
	{
		audioClip = GetComponent<AudioSource> ();
	}


	public void One ()
	{
		inputUser = string.Concat (inputUser, "1");
	}

	public void Two ()
	{
		inputUser = string.Concat (inputUser, "2");
	}

	public void Three ()
	{
		inputUser = string.Concat (inputUser, "3");
	}

	public void Four ()
	{
		inputUser = string.Concat (inputUser, "4");
	}

	public void Five ()
	{
		inputUser = string.Concat (inputUser, "5");
	}

	public void Six ()
	{
		inputUser = string.Concat (inputUser, "6");
	}

	public void Seven ()
	{
		inputUser = string.Concat (inputUser, "7");
	}

	public void Eight ()
	{
		inputUser = string.Concat (inputUser, "8");
	}

	public void Nine ()
	{
		inputUser = string.Concat (inputUser, "9");
	}

	public void Zero ()
	{
		inputUser = string.Concat (inputUser, "0");
	}

	public void Accept ()
	{
		if (inputUser.Equals (safeCode)) {
			audioClip.PlayOneShot (soundFile, 1);
			safeDoor.transform.localEulerAngles = new Vector3 (0, -90, 0);
			Destroy (this.gameObject);
		}
	}

	public void DeleteAll ()
	{
		inputUser = "";
	}

}
