using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
	private GameObject egg;
	private float pushForce = 1000.0f;
	private AudioSource audioSource;
	public AudioClip[] audioClips;

    // Start is called before the first frame update
    void Start()
    {
		egg = gameObject;
		audioSource = egg.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
	{
		if (Input.GetButtonDown("z"))
		{
			pushLeft();
		}

		if (Input.GetButtonDown("t"))
		{
			pushRight();
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		audioSource.PlayOneShot(audioClips[(int)Mathf.Floor(Random.value * audioClips.Length)]);
	}

	private void pushLeft()
	{
		Vector3 force = new Vector3(pushForce * Time.deltaTime, pushForce * Time.deltaTime, 0.0f);
		addForce(force);
	}

	private void pushRight()
	{
		Vector3 force = new Vector3(-1 * (pushForce * Time.deltaTime), pushForce * Time.deltaTime, 0.0f);
		addForce(force);
	}

	private void addForce(Vector3 force)
	{
		Rigidbody rb = egg.GetComponent<Rigidbody>();
		rb.AddForce(force);
	}
}
