using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerJudge : MonoBehaviour
{
	public const int PlayerCount = 2;


	/// <summary>
	/// The core of the Judge, it's where the magic starts to happen. :)
	/// </summary>
	void Start ()
	{
		string[] input = Poker.Game;

		int[] playerWins = new int[PlayerCount];
		int drawCount = 0;

		Round[] rounds = ConvertToRounds(input);

		// Go through all rounds and determine the winner.
		foreach (Round round in rounds)
		{
			int winner = round.Winner();

			if (winner == -1)
			{
				drawCount++;
			}
			else
			{
				playerWins[winner]++;
			}
		}

		Debug.LogFormat("WINS [ P1: {0}, P2: {1}, draws: {2} ]", playerWins[0], playerWins[1], drawCount);
	}


	/// <summary>
	/// Converts the input file into readable classes.
	/// </summary>
	private Round[] ConvertToRounds(string[] input)
	{
		List<Round> rounds = new List<Round>();

		foreach (string roundInput in input)
		{
			rounds.Add(new Round(roundInput));
		}

		return rounds.ToArray();
	}
}
