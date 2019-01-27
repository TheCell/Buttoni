using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBird : MonoBehaviour
{
	private float currentRotation;

	// Start is called before the first frame update
	void Start()
    {
		currentRotation = 0.0f;

	}

    // Update is called once per frame
    void Update()
    {
        
    }

	void FixedUpdate()
	{
		currentRotation += 0.5f;
		Quaternion rotateTo = Quaternion.Euler(-90.0f, currentRotation, 0.0f);
		gameObject.transform.localRotation = rotateTo;
	}
}
