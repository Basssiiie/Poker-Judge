using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
	public string FileName = "Game";
	public int RoundAmount = 1000;


	void Start()
	{
		PokerGameFile file = new PokerGameFile(FileName);

		for (int i = 0; i < RoundAmount; i++)
		{
			PokerRound round = new PokerRound(2);

			file.Write(round);
		}

		file.Save();

		Debug.LogFormat("File {0} generated!", FileName);
	}
}
