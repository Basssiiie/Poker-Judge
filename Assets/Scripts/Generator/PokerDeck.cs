using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PokerDeck
{
	private static readonly char[] Faces = new char[] { 'H', 'C', 'D', 'S' };
	private static readonly char[] Values = new char[] { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };

	private static System.Random random = new System.Random();

	public Queue<string> Cards;



	public PokerDeck(bool shuffle)
	{
		// Set the string list to size 52.
		int deckSize = Faces.Length * Values.Length; 
		string[] cards = new string[deckSize];

		// Add all cards
		for (int f = 0; f < Faces.Length; f++)
		{
			for (int v = 0; v < Values.Length; v++)
			{
				int idx = (f * Values.Length) + v;

				cards[idx] = Faces[f].ToString() + Values[v].ToString();
			}
		}

		if (shuffle)
		{
			// Shuffle it randomly with System.Random & Linq
			cards = cards.OrderBy(x => random.Next()).ToArray();
		}

		Cards = new Queue<string>(cards);
	}


	/// <summary>
	/// Returns a String Array with 5 cards.
	/// </summary>
	public string[] DrawHand()
	{
		string[] cards = new string[5];

		for (int i = 0; i < 5; i++)
		{
			cards[i] = Cards.Dequeue();
		}
		return cards;
	}
}
