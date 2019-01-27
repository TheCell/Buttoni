using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snail : MonoBehaviour
{
	private GameObject snail;
	public float maxScale = 3.0f;
	private float currentScale = 1.0f;
	private float scaleStep = 1.0f;
	private bool isEnlarge = false;
	private bool fixFront = false;
	private bool fixBack = false;
	private AudioSource snailSoundSource;
	public AudioClip[] shrinkClips;
	public AudioClip[] enlargeClips;

	// Start is called before the first frame update
	void Start()
    {
		// controlls: z,i,p
		snail = gameObject;
		snailSoundSource = snail.GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update()
	{
		if (Input.GetButtonDown("i"))
		{
			snailSoundSource.PlayOneShot(enlargeClips[(int)Mathf.Floor(Random.value * enlargeClips.Length)]);
			isEnlarge = true;
		}
		if (Input.GetButtonUp("i"))
		{
			snailSoundSource.PlayOneShot(shrinkClips[(int)Mathf.Floor(Random.value * enlargeClips.Length)]);
			isEnlarge = false;
		}
		if (Input.GetButtonDown("p"))
		{
			fixFront = true;
		}
		if (Input.GetButtonUp("p"))
		{
			fixFront = false;
		}
		if (Input.GetButtonDown("z"))
		{
			fixBack = true;
		}
		if (Input.GetButtonUp("z"))
		{
			fixBack = false;
		}

		float deltaScale = 0.0f;
		if (isEnlarge)
		{
			deltaScale = enlarge();
		}
		else
		{
			deltaScale = shrink();
		}

		if (fixFront)
		{
			fixPivotTo(PivotFixpoint.A, deltaScale);
		}
		if (fixBack)
		{
			fixPivotTo(PivotFixpoint.B, deltaScale);
		}
	}

	private float enlarge()
	{
		float deltaScale = currentScale;
		currentScale = currentScale + scaleStep * Time.deltaTime;
		currentScale = Mathf.Min(maxScale, currentScale);
		deltaScale = Mathf.Abs(deltaScale - currentScale);
		snail.transform.localScale = new Vector3(currentScale, 1.0f / currentScale, 1.0f / currentScale);
		return deltaScale;
	}

	private float shrink()
	{
		float deltaScale = currentScale;
		currentScale = currentScale - scaleStep * Time.deltaTime;
		currentScale = Mathf.Max(currentScale, 1.0f);
		deltaScale = Mathf.Abs(deltaScale - currentScale);
		snail.transform.localScale = new Vector3(currentScale, 1.0f / currentScale, 1.0f / currentScale);
		return deltaScale;
	}

	private void fixPivotTo(PivotFixpoint fixpoint, float delta)
	{
		// midpoint + currentscale to A
		if (fixpoint == PivotFixpoint.A)
		{
			Vector3 position = gameObject.transform.position;
			position.x = gameObject.transform.position.x + (delta) /2;
			gameObject.transform.position = position;
		}
		// midpoint + currentscale to B
		if (fixpoint == PivotFixpoint.B)
		{
			Vector3 position = gameObject.transform.position;
			position.x = gameObject.transform.position.x - (delta) / 2;
			gameObject.transform.position = position;
		}
	}

	enum PivotFixpoint
	{
		A = 1,
		B = 2
	}
}
