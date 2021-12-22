using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
	private AudioSource audioSrc;

	private float musicVolume = 1f;

	void Start ()
	{
		audioSrc = GetComponent<AudioSource>();
	}

	void Update()
	{
		audioSrc.volume = musicVolume;
	}



	public void SetVolume (float volume)
	{ 
		musicVolume = volume;  
	}
}
