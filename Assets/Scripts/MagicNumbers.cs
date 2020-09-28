using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MagicNumbers : MonoBehaviour
{
	int moves;
	public Text textMoves;

	public int min = 1;
	public int max = 1000;
	public Text textMinMax;

	int guess;
	public Text textGuess;

	void Start()
	{
		min = 1;
		max = 1000;
		moves = 0;
		textMinMax.text = $"Загадайте число \nот <color=#ff0000ff>{min}</color> до <color=#ff0000ff>{max}</color>...";
		UpdateGuess();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			UpdateGuess();
		}

		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			UpdateGuess();
		}

		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			textMoves.text = $"Количество ходов: <color=#ff0000ff>{moves}</color>";
		}

	}

	void UpdateGuess()
		{
		guess = (min + max) / 2;
		moves++;
		textGuess.text = guess.ToString();
	}
}
