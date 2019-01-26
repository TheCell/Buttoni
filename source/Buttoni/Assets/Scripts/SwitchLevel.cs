using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel : MonoBehaviour
{
	public Levels switchTo;
	private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter(Collider collider)
	{
		
		if (collider.gameObject.tag == "Player")
		{
			audioSource.Play(0);
			//yield return new WaitForSeconds(3.0f);
			StartCoroutine(switchLevel(this.switchTo));
		}
	}

	IEnumerator switchLevel(Levels level)
	{
		yield return new WaitForSeconds(3.0f);

		switch (level)
		{
			case Levels.SampleScene:
				SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
				break;
			case Levels.SnailLevel:
				SceneManager.LoadScene("SnailScene", LoadSceneMode.Single);
				break;
		}
	}
}

public enum Levels
{
	SampleScene,
	SnailLevel
}

/*
public class LevelNames
{
	private LevelNames(string levelName)
	{
		LevelName = levelName;
	}

	public string LevelName { get; set; }

	public static LevelNames SampleScene { get { return new LevelNames("SampleScene"); } }
	public static LevelNames SnailLevel { get { return new LevelNames("simonTestscene"); } }
}
*/