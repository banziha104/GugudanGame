using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuGudan : MonoBehaviour
{
	public string question = "김연아 == 농구선수 ?";
	public bool answer = false;
	public Text mainText;

	// Use this for initialization
	void Start()
	{
		mainText.text = "김연아 농구선수임?";

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void ForGugudan()
	{
		mainText.text = "";
		for (int i = 1; i <= 9; i++)
		{
			for (int j = 1; j <= 9; j++)
			{
				string str = i + "*" + j + "=" + (i * j) + " ";
				mainText.text += str;
			}
			mainText.text += "\n";
		}
	}

	public void WhileGugudan()
	{
		mainText.text = "";
		int i = 1;
		while (i <= 9)
		{
			int j = 1;
			while (j <= 9)
			{
				string str = i + " * " + j + " = " + (i * j) + " ";
				mainText.text += str;
				j++;
			}
			mainText.text += "/n";
			i++;
		}
	}

	public void QuizInput(bool input)
	{
		if (input == answer)
		{
			mainText.text = "맞음";
		}
		else
		{
			mainText.text = "틀림";
		}
	}
}
