﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AltFAndFour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetButton("alt") && Input.GetButton("f") && Input.GetButton("4"))
		{
			SceneManager.LoadScene("EggScene", LoadSceneMode.Single);
		}
    }
}
