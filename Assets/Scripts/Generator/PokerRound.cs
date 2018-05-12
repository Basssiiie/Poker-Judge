using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerRound
{
	private PokerDeck deck;

	public string[][] players;


	public PokerRound(int playerCount)
	{
		deck = new PokerDeck(true);
		players = new string[playerCount][];

		// Draw a hand for all players
		for (int p = 0; p < playerCount; p++)
		{
			players[p] = deck.DrawHand();
		}
	}
}
