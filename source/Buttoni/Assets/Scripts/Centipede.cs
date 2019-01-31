using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centipede : MonoBehaviour
{
	private GameObject centipede;
	private float pushForce = -5.1f;
	public GameObject feet;
	private GameObject[] allFeets;
	private AudioSource audioSource;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
		centipede = gameObject;
        rb = centipede.GetComponent<Rigidbody>();
        audioSource = centipede.GetComponent<AudioSource>();
		allFeets = new GameObject[140];

		for (int i = 0; i < allFeets.Length; i++)
		{
			GameObject newFeet = Instantiate(feet);
			newFeet.transform.position = feet.transform.position;
			newFeet.transform.rotation = feet.transform.rotation;
			newFeet.transform.SetParent(centipede.transform);
			newFeet.transform.localScale = Vector3.one;


			Vector3 position = newFeet.transform.localPosition;
			position.x -= (0.0005f * i);
			newFeet.transform.localPosition = position;
			newFeet.SetActive(true);
			allFeets[i] = newFeet;
		}
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.anyKeyDown)
		{
		}

		if (Input.anyKey)
		{
			pushCentipede();
			randomLegMovement();
			if (!audioSource.isPlaying)
			{
				audioSource.Play();
			}
		}
		else
		{
			if (audioSource.isPlaying)
			{
				audioSource.Pause();
			}
		}
	}

    private void FixedUpdate()
    {
        if (Input.anyKey)
        {
            pushCentipede();
        }
    }

    private void randomLegMovement()
	{
		//currentRotation = feet.transform.localRotation;
		for(int i = 0; i < 20; i++)
		{
			GameObject footpair = allFeets[(int)Mathf.Floor(Random.value * allFeets.Length)];
			float randomXRotation = (Random.value * 2 - 1) * 20.0f - 90.0f;
			Quaternion rotateTo = Quaternion.Euler(randomXRotation, 90.0f, -90.0f);
			footpair.transform.localRotation = rotateTo;
		}
	}

	private void pushCentipede()
	{
		float applyForce = pushForce;
		if (Input.GetButton("speedboost"))
		{
			applyForce -= 1.0f;
		}
		rb.AddRelativeForce(new Vector3(applyForce, 0.0f, 0.0f));
	}
}
