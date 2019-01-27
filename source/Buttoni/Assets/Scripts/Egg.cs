using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
	private GameObject egg;
	private float pushForce = 800.0f;

    // Start is called before the first frame update
    void Start()
    {
		egg = gameObject;
    }

    // Update is called once per frame
    void Update()
	{
		if (Input.GetButtonDown("t"))
		{
			pushLeft();
		}

		if (Input.GetButtonDown("z"))
		{
			pushRight();
		}
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
