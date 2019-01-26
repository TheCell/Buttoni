using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pancake : MonoBehaviour
{
	private GameObject pancake;

    // Start is called before the first frame update
    void Start()
    {
		pancake = gameObject;
    }

    // Update is called once per frame
    void Update()
	{
		if (Input.GetButtonDown("c"))
		{
			turnLeft();
		}
		if (Input.GetButtonDown("b"))
		{
			turnRight();
		}
		if (Input.GetButtonDown("v"))
		{
			jump();
		}
	}

	void turnLeft()
	{
		Rigidbody rb = pancake.GetComponent<Rigidbody>();
		rb.AddRelativeForce(new Vector3(0.0f, 100.0f, 0.0f));
		rb.AddRelativeTorque(new Vector3(0.0f, 600.0f, 0.0f));
	}

	void turnRight()
	{
		Rigidbody rb = pancake.GetComponent<Rigidbody>();
		rb.AddRelativeForce(new Vector3(0.0f, 100.0f, 0.0f));
		rb.AddRelativeTorque(new Vector3(0.0f, -600.0f, 0.0f));
	}

	void jump()
	{
		Rigidbody rb = pancake.GetComponent<Rigidbody>();
		rb.AddRelativeForce(new Vector3(400.0f, 1500.0f, 0.0f));
	}
}
