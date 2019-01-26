using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel : MonoBehaviour
{
	public Levels switchTo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			switchLevel(this.switchTo);
		}
	}

	public void switchLevel(Levels level)
	{
		switch (level)
		{
			case Levels.SampleScene:
				SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
				break;
			case Levels.SnailLevel:
				SceneManager.LoadScene("SimonTestscene", LoadSceneMode.Single);
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