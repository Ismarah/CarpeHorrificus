using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
	public static Gamemanager singleton;
	public int tapeCount;
	public bool safePinComplete;
	public bool playerHasKey;
	public GameObject paper1;
	public GameObject paper2;
	public GameObject key;
	public bool crawlerSpawned;
	public GameObject player;
	public GameObject fade;
	Camera main;
	public AudioClip soundfile;
	public AudioClip backgroundMusic;
	public AudioClip zombieLaugh;
	AudioSource audioCLip;
	bool done;

	private void Awake ()
	{
		if (singleton != null) {
			Destroy (gameObject);
		} else {
			singleton = this;
		}
	}

	void Start ()
	{
		main = Camera.main;
		audioCLip = GetComponent<AudioSource> ();
		audioCLip.PlayOneShot (backgroundMusic);
	}

	void Update ()
	{

		if (paper1.GetComponent<PaperScript> ().onDesk && paper2.GetComponent<PaperScript> ().onDesk) {
			safePinComplete = true;
		}
		if (key.GetComponent<Key> ().onDesk) {
			playerHasKey = true;
		}
		if (tapeCount == 3) {
			key.SetActive (true);
		}
		if (crawlerSpawned) {
			GetComponent<AudioSource> ().clip = soundfile;
			audioCLip.loop = false;
			if (!done) {
				audioCLip.PlayOneShot (soundfile);
				done = true;
			}
			if (main.transform.localEulerAngles.y >= 120 && main.transform.localEulerAngles.y <= 250) {

				GetComponent<AudioSource> ().clip = zombieLaugh;
				audioCLip.PlayOneShot (zombieLaugh);
				player.GetComponent<TeleportScript> ().enabled = false;
				//Invoke ("SpawnCanvas", 2);
				//Debug.Log ("lauuughhhh");
				crawlerSpawned = false;
				GetComponent<Fading> ().BeginFade (1);
			}
		}
	}


	void SpawnCanvas ()
	{
		Instantiate (fade);
	}

	public void StopMusic ()
	{
		audioCLip.Stop ();
	}

	public void PlayNewMusic (AudioClip newMusic)
	{
		GetComponent<AudioSource> ().clip = newMusic;
		audioCLip.PlayOneShot (newMusic);
	}
}
