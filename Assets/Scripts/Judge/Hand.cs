using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Hand
{
	public Card[] Cards;


	/// <summary>
	/// Creates a Hand instance based on the input, with cards sorted by Value (low to high).
	/// </summary>
	/// <param name="input">Expected: a string with card information seperated by a space.</param>
	public Hand(string input)
	{
		string[] cardInput = input.Split(' ');

		List<Card> cardList = new List<Card>();
		foreach (string info in cardInput)
		{
			cardList.Add(new Card(info));
		}

		// IMPORTANT: Using Linq to sort the array based on Value, then save to public Cards.
		Cards = cardList.OrderBy(x => x.Value).ToArray();
	}
	

	public override string ToString()
	{
		string value = string.Empty;

		foreach (Card card in Cards)
		{
			value += (card.ToString() + ' ');
		}

		return string.Format("[ {0}]", value);
	}
}
