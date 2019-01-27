using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pancake : MonoBehaviour
{
	private GameObject pancake;
	private AudioSource audioSource;
	public AudioClip[] audioClips;

    // Start is called before the first frame update
    void Start()
    {
		pancake = gameObject;
		audioSource = pancake.GetComponent<AudioSource>();

	}

    // Update is called once per frame
    void Update()
	{
		if (Input.GetButtonDown("c"))
		{
			audioSource.PlayOneShot(audioClips[(int)Mathf.Floor(Random.value * audioClips.Length)]);
			turnRight();
		}
		if (Input.GetButtonDown("b"))
		{
			audioSource.PlayOneShot(audioClips[(int)Mathf.Floor(Random.value * audioClips.Length)]);
			turnLeft();
		}
		if (Input.GetButtonDown("v"))
		{
			audioSource.PlayOneShot(audioClips[(int)Mathf.Floor(Random.value * audioClips.Length)]);
			jump();
		}
	}

	void turnLeft()
	{
		Rigidbody rb = pancake.GetComponent<Rigidbody>();
		rb.AddRelativeForce(new Vector3(0.0f, 100.0f, 0.0f));
		rb.AddRelativeTorque(new Vector3(0.0f, 200.0f, 0.0f));
	}

	void turnRight()
	{
		Rigidbody rb = pancake.GetComponent<Rigidbody>();
		rb.AddRelativeForce(new Vector3(0.0f, 100.0f, 0.0f));
		rb.AddRelativeTorque(new Vector3(0.0f, -200.0f, 0.0f));
	}

	void jump()
	{
		Rigidbody rb = pancake.GetComponent<Rigidbody>();
		rb.AddRelativeForce(new Vector3(400.0f, 800.0f, 0.0f));
	}
}
