using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointTest : MonoBehaviour
{
	public HingeJoint legpartHinge1;
	public HingeJoint legpartHinge5;

	// Start is called before the first frame update
	void Start()
    {
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButton("8"))
		{
			closeJoint(legpartHinge1);
		}
		else
		{
			openJoint(legpartHinge1);
		}


		if (Input.GetButton("3"))
		{
			closeJoint(legpartHinge5);
		}
		else
		{
			openJoint(legpartHinge5);
		}
	}

	void closeJoint(HingeJoint joint)
	{
		JointSpring jointSpring = joint.spring;
		jointSpring.targetPosition = -160.0f;
		joint.spring = jointSpring;
	}

	void openJoint(HingeJoint joint)
	{
		JointSpring jointSpring = joint.spring;
		jointSpring.targetPosition = -60.0f;
		joint.spring = jointSpring;
	}
}
