using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
	private GameObject egg;
	private float pushForce = 10.0f;
    private float upForce = 10.0f;
	private AudioSource audioSource;
	public AudioClip[] audioClips;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
		egg = gameObject;
        rb = egg.GetComponent<Rigidbody>();
		audioSource = egg.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
	{
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("z"))
        {
            pushLeft();
        }

        if (Input.GetButton("t"))
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
        Vector3 force;

        if (Mathf.Abs(rb.velocity.y) < upForce)
        {
            force = new Vector3(pushForce, upForce, 0.0f);
        }
        else
        {
            force = new Vector3(pushForce, 0.0f, 0.0f);
        }

        if (rb.velocity.x < 5.0f)
        {
            rb.AddForce(force);
        }
    }

	private void pushRight()
	{
        Vector3 force;

        if (Mathf.Abs(rb.velocity.y) < upForce)
        {
            force = new Vector3(-1 * (pushForce), upForce, 0.0f);
        }
        else
        {
            force = new Vector3(-1 * (pushForce), 0.0f, 0.0f);
        }

        if (rb.velocity.x > -5.0f)
        {
            rb.AddForce(force);
        }
    }
}
