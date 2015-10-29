using UnityEngine;
using System.Collections;

public class audiomanager : MonoBehaviour {

	public AudioClip wing;
	public AudioClip wing_start;
	public AudioClip die;
	public AudioClip score;
	public AudioClip hit;

	AudioSource audiosource;
	public static audiomanager Instance;

	void Awake(){
		Instance = this;
		audiosource = GetComponent<AudioSource> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayAudio(AudioClip c)
	{
		audiosource.PlayOneShot (c);
	}
}
