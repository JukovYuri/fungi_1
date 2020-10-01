using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MagicNumbers : MonoBehaviour
{
	public int start_min = 1;
	public int start_max = 1000;

	public Text textMoves;
	public Text textMinMax;

	public Text textGuess;

	public GameObject PanelStart;
	public GameObject PanelGame;
	public GameObject PanelGameStart;
	public GameObject PanelGameEnd;

	int min;
	int max;
	int moves;
	int guess;

	public void Start()
	{
		min = start_min;
		max = start_max;
		moves = 0;
		guess = 0;
		textMinMax.text = $"Загадайте число \nот <color=#e7a9ad>{min}</color> до <color=#e7a9ad>{max}</color>...";
		UpdateGuess();
		PanelGameEnd.SetActive(false);
		PanelGame.SetActive(false);
		PanelStart.SetActive(true);
	}

	void Update()
	{
		BtnUpDown();
		BtnOkStart();
		BtnOkGameStart();
		BtnOkGameEnd();
	}


	public void BtnOkStart ()
	{
		if ( PanelStart.activeSelf && (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)) )
		{
			//OkStart();
			print(PanelStart.activeSelf);
			print(Input.GetKeyDown(KeyCode.KeypadEnter));
		}
	}

	public void BtnOkGameStart()
	{
		if (PanelGameStart.activeSelf && ( (Input.GetKeyDown(KeyCode.KeypadEnter)) || (Input.GetKeyDown(KeyCode.Return)) ))
		{
			OkGame();
		}
	}

	public void BtnOkGameEnd()
    {
		if (PanelGameEnd.activeSelf && ((Input.GetKeyDown(KeyCode.KeypadEnter)) || (Input.GetKeyDown(KeyCode.Return))))
		{
			OkEnd();
		}
	}

	public void Up()
	{
		min = guess;
		UpdateGuess();
	}

	public void Down()
	{
		max = guess;
		UpdateGuess();
	}

	public void OkGame()
	{
		PanelGameEnd.SetActive(true);
		PanelGameStart.SetActive(false);
		textMoves.text = $"Количество ходов: <color=#e7a9ad>{moves}</color>";
		textGuess.text = $"{guess}";
	}

	public void OkStart()
	{
		PanelStart.SetActive(false);
		PanelGame.SetActive(true);
		PanelGameStart.SetActive(true);
	}

	public void OkEnd()
	{
		Start();
	}

	public void BtnUpDown()
	{
		if (PanelGameStart.activeSelf && Input.GetKeyDown(KeyCode.UpArrow))
		{
			Up();
		}

		if (PanelGameStart.activeSelf && Input.GetKeyDown(KeyCode.DownArrow))
		{
			Down();
		}
	}

	public void UpdateGuess()
		{
		guess = (min + max) / 2;
		moves++;
		textGuess.text = $"{guess} <color=#ffffff>???</color>";
	}

}