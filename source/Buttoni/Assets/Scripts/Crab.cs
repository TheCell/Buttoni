using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
	public HingeJoint bottomLeg1Hinge;
	public HingeJoint bottomLeg2Hinge;
	public HingeJoint bottomLeg3Hinge;
	public HingeJoint bottomLeg4Hinge;
	public HingeJoint bottomLeg5Hinge;
	public HingeJoint bottomLeg6Hinge;
	public HingeJoint bottomLeg7Hinge;
	public HingeJoint bottomLeg8Hinge;
	private AudioSource audioSource;
	public AudioClip[] audioClips;
    private bool shouldJump = false;

	// Start is called before the first frame update
	void Start()
    {
		audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
	{
		if (Input.GetButtonDown("i") || Input.GetButtonDown("w"))
		{
			audioSource.PlayOneShot(audioClips[(int)Mathf.Floor(Random.value * audioClips.Length)]);
		}

		if (Input.GetButton("8"))
		{
		}
		else
		{
		}
		if (Input.GetButton("i"))
		{
			closeJoint(bottomLeg2Hinge);
			closeJoint(bottomLeg4Hinge);
		}
		else
		{
			openJoint(bottomLeg2Hinge);
			openJoint(bottomLeg4Hinge);
		}
		if (Input.GetButton("i"))
		{
			closeJoint(bottomLeg1Hinge);
			closeJoint(bottomLeg3Hinge);
		}
		else
		{
			openJoint(bottomLeg1Hinge);
			openJoint(bottomLeg3Hinge);
		}
		if (Input.GetButton("m"))
		{
		}
		else
		{
		}


		if (Input.GetButton("3"))
		{
		}
		else
		{
		}
		if (Input.GetButton("w"))
		{
			closeJoint(bottomLeg6Hinge);
			closeJoint(bottomLeg8Hinge);
		}
		else
		{
			openJoint(bottomLeg6Hinge);
			openJoint(bottomLeg8Hinge);
		}
		if (Input.GetButton("w"))
		{
			closeJoint(bottomLeg5Hinge);
			closeJoint(bottomLeg7Hinge);
		}
		else
		{
			openJoint(bottomLeg5Hinge);
			openJoint(bottomLeg7Hinge);
		}
		if (Input.GetButton("x"))
		{
		}
		else
		{
		}
	}

    private void FixedUpdate()
    {
        if (shouldJump)
        {
            jumpUp();
            this.shouldJump = true;
        }
    }

    void closeJoint(HingeJoint joint)
	{
        this.shouldJump = true;
		JointSpring jointSpring = joint.spring;
		jointSpring.targetPosition = 160.0f;
		joint.spring = jointSpring;
	}

	void openJoint(HingeJoint joint)
	{
		JointSpring jointSpring = joint.spring;
		jointSpring.targetPosition = -30.0f;
		joint.spring = jointSpring;
	}

	private void jumpUp()
	{
		Rigidbody rb = gameObject.GetComponent<Rigidbody>();
		rb.AddRelativeForce(new Vector3(10.0f, 0.0f, 20.0f));
	}
}
