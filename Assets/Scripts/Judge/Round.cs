using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round
{
	public Hand[] Players;


	/// <summary>
	/// Creates a Round instance based on the input.
	/// </summary>
	/// <param name="input">Expected: a string with card hands of all players</param>
	public Round(string input)
	{
		string[] handInput = input.Split('|');

		List<Hand> hands = new List<Hand>();
		foreach (string info in handInput)
		{
			hands.Add(new Hand(info));
		}

		Players = hands.ToArray();
	}


	/// <summary>
	/// Calculates the winner and returns the index. (-1 = draw, 0 = first player, 1 = second player etc.)
	/// </summary>
	/// <returns>Array index of the winning player, or -1 if draw</returns>
	public int Winner()
	{
		int[] scores = new int[Players.Length];

		for (int p = 0; p < Players.Length; p++)
		{
			Hand hand = Players[p];

			// Check each possible poker set, if it returns a score instead of 0 then finish and 
			// continue to the next player.
			if (PokerJudge.ScoreGoed)
			{
				scores[p] = PokerScore.RoyalFlush(hand);
				if (scores[p] > 0) continue;

				scores[p] = PokerScore.StraightFlush(hand);
				if (scores[p] > 0) continue;

				scores[p] = PokerScore.FourOfAKind(hand);
				if (scores[p] > 0) continue;

				scores[p] = PokerScore.FullHouse(hand);
				if (scores[p] > 0) continue;

				scores[p] = PokerScore.Flush(hand);
				if (scores[p] > 0) continue;

				scores[p] = PokerScore.Straight(hand);
				if (scores[p] > 0) continue;
			}

			scores[p] = PokerScore.ThreeOfAKind(hand);
			if (scores[p] > 0) continue;

			scores[p] = PokerScore.TwoPair(hand);
			if (scores[p] > 0) continue;

			scores[p] = PokerScore.OnePair(hand);
			if (scores[p] > 0) continue;

			scores[p] = PokerScore.HighestCard(hand);
		}


		// Now find the player with the highest score.
		if (scores[0] == scores[1])
		{
			return -1; // draw
		}
		else if (scores[0] > scores[1])
		{
			return 0; // player 1 wins
		}
		else
		{
			return 1; // player 2 wins
		}
	}
}
