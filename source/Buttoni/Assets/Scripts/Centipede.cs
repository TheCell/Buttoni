using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centipede : MonoBehaviour
{
	private GameObject centipede;
	private float pushForce = 400.0f;

    // Start is called before the first frame update
    void Start()
    {
		centipede = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.anyKey)
		{
			pushCentipede();
		}
    }

	private void pushCentipede()
	{
		Rigidbody rb = centipede.GetComponent<Rigidbody>();
		rb.AddRelativeForce(new Vector3(0.0f, 0.0f, pushForce * Time.deltaTime));
	}
}
