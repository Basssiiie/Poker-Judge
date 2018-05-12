using System.Collections.Generic;
using UnityEngine;


public static class PokerTools
{
	/// <summary>
	/// Short test function to check if there are any duplicate cards in this round, which would
	/// mean my deck generator is faulty. 
	/// </summary>
	public static void FindDuplicateCards(Round round, int roundNumber = -1)
	{
		HashSet<string> cards = new HashSet<string>();

		foreach (Hand hand in round.Players)
		{
			foreach (Card card in hand.Cards)
			{
				string cardStr = card.ToString();
				if (!cards.Contains(cardStr))
				{
					cards.Add(cardStr);
				}
				else
				{
					Debug.LogWarningFormat("DUPLICATE CARD FOUND: Line {0}, Card {1}{2}", roundNumber, card.Face, card.Value);
				}
			}
		}
	}
}
