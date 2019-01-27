using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSounds : MonoBehaviour
{
	private AudioSource audioSource;
	public AudioClip[] audioclips;
	private float minDelay = 6.0f;
	private float lastSound;
	private float timeTillNextSound;

    // Start is called before the first frame update
    void Start()
    {
		lastSound = Time.realtimeSinceStartup;
		audioSource = gameObject.GetComponent<AudioSource>();
		timeTillNextSound = Random.value * 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (lastSound + minDelay + timeTillNextSound < Time.realtimeSinceStartup)
		{
			timeTillNextSound = Random.value * 10.0f;
			lastSound = Time.realtimeSinceStartup;
			playSound();
		}
    }

	void playSound()
	{
		audioSource.PlayOneShot(audioclips[(int)Mathf.Floor(Random.value * audioclips.Length)]);
	}
}
