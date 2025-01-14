﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public PlayerController player;
	public Text scoreLabel;
	public LifePanel lifePanel;
	public int itemscore;
	public static int score;
	public static int highscore;

	void Awake()
    {
		highscore = 0;
    }

    void Start()
    {
		itemscore = 0;
	}

	void Update()
	{
		// 점수 업데이트 
		score = CalcScore() + itemscore;
		scoreLabel.text = score.ToString();

		// 생명 업데이트
		lifePanel.UpdateLife(player.Life());

		// 생명 개수 0 되거나 떨어지면 게임 종료
		if (player.Life() <= 0 || player.transform.position.y < 0)
		{
			// 더이상 업데이트 안함
			enabled = false;

			// 하이스코어 업데이트
			if (highscore < score)
			{
				highscore = score;
			}

			loadEnd();
		}
	}

	int CalcScore()
	{
		return (int)player.transform.position.z * 100;
	}

	void loadTitle()
	{
		SceneManager.LoadScene("Title");
	}

	void loadEnd()
    {
		SceneManager.LoadScene("End");
    }
}
