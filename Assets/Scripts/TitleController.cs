﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{


	public void Start()
	{
		

	}

    public void Update()
    {
		if (Input.anyKeyDown)
			loadMain();
	}

    public void loadMain()
	{
		SceneManager.LoadScene("Main");
	}
}
