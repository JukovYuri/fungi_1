using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MagicNumbers : MonoBehaviour
{
	public int moves;
	public Text textMoves;

	public int min = 1;
	public int max = 1000;
	public Text textMinMax;

	public int guess;
	public Text textGuess;

	public GameObject PanelStart;
	public GameObject PanelGameStart;
	public GameObject PanelGameEnd;


	 public void Start()
	{
		min = 1;
		max = 1000;
		moves = 0;
		textMinMax.text = $"Загадайте число \nот <color=#e7a9ad>{min}</color> до <color=#e7a9ad>{max}</color>...";
		UpdateGuess();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Up();
		}

		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Down();
		}

		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			Ok();
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

	public void Ok()
	{
		PanelGameEnd.SetActive(true);
		PanelGameStart.SetActive(false);
		textMoves.text = $"Количество ходов: <color=#e7a9ad>{moves}</color>";
		textGuess.text = $"{guess}";
	}

	public void UpdateGuess()
		{
		guess = (min + max) / 2;
		moves++;
		textGuess.text = $"{guess} <color=#ffffff>???</color>";
	}

}