using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
	private GameObject crab;
	private float legForce = 300.0f;
	public GameObject leg1;
	public GameObject leg2;
	public GameObject leg3;
	public GameObject leg4;
	public GameObject leg5;
	public GameObject leg6;
	public GameObject leg7;
	public GameObject leg8;

	// Start is called before the first frame update
	void Start()
    {
		crab = gameObject;
	}

    // Update is called once per frame
    void Update()
    {
		moveLeg();
	}

	private void moveLeg()
	{

		if (Input.GetButton("8"))
		{
		}
		else
		{
		}
		
		if (Input.GetButton("i"))
		{
			addForce(leg6);
			addForce(leg8);
		}
		else
		{
			HingeJoint hinge = leg6.GetComponent<HingeJoint>();
			hinge.useMotor = false;
			HingeJoint hinge8 = leg8.GetComponent<HingeJoint>();
			hinge8.useMotor = false;
		}
		if (Input.GetButton("k"))
		{
			addForce(leg5);
			addForce(leg7);
		}
		else
		{
			HingeJoint hinge5 = leg5.GetComponent<HingeJoint>();
			hinge5.useMotor = false;
			HingeJoint hinge = leg7.GetComponent<HingeJoint>();
			hinge.useMotor = false;
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
			addForce(leg2);
			addForce(leg4);
		}
		else
		{
			HingeJoint hinge = leg2.GetComponent<HingeJoint>();
			hinge.useMotor = false;
			HingeJoint hinge4 = leg4.GetComponent<HingeJoint>();
			hinge4.useMotor = false;
		}
		if (Input.GetButton("s"))
		{
			addForce(leg1);
			addForce(leg3);
		}
		else
		{
			HingeJoint hinge1 = leg1.GetComponent<HingeJoint>();
			hinge1.useMotor = false;
			HingeJoint hinge = leg3.GetComponent<HingeJoint>();
			hinge.useMotor = false;
		}
		if (Input.GetButton("x"))
		{
		}
		else
		{
		}
	}

	private void addForce(GameObject leg)
	{
		HingeJoint hinge = leg.GetComponent<HingeJoint>();

		// Make the hinge motor rotate with 90 degrees per second and a strong force.
		JointMotor motor = hinge.motor;
		motor.force = legForce;
		motor.targetVelocity = -90;
		motor.freeSpin = false;
		hinge.motor = motor;
		hinge.useMotor = true;
	}
}
