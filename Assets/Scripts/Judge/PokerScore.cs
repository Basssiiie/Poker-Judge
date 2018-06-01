using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class PokerScore
{
	/*   - - - - - Score Calculation - - - - - 
	 * High Card		0	+ highest card in hand
	 * One Pair			100 + card value of pair
	 * Two Pair			200 + card value of highest pair
	 * Three of a Kind	300 + card value of set
	 * Straight			400 + highest card in hand
	 * Flush			500 + highest card in hand
	 * Full House		600 + highest card in hand
	 * Four of a Kind	700 + card value of set
	 * Straight Flush	800 + highest card in hand
	 * Royal Flush		900
	 */

	
	/// <summary>
	/// Returns the highest valued card in the hand.
	/// </summary>
	/// <returns>Value of highest card.</returns>
	public static int HighestCard(Hand hand)
	{
		// The hand is expected to be sorted, so it's the last value.
		Card lastCard = hand.Cards.Last();
		return lastCard.Value;
	}


	/// <summary>
	/// One pair: two cards have the same Value.
	/// </summary>
	/// <returns>Score of 100 + value of the cards in that pair.</returns>
	public static int OnePair(Hand hand)
	{
		int pairValue = SomeOfAKind(hand, 2);
		if (pairValue != 0)
		{
			return (100 + pairValue);
		}
		else return 0;
	}


	/// <summary>
	/// Two Pair: One Pair of two cards, plus a different Pair of two cards.
	/// </summary>
	/// <returns>Score of 200 + value of the cards in that pair.</returns>
	public static int TwoPair(Hand hand)
	{
		Dictionary<int, int> groupedCards = GroupCardsByValue(hand);
		int countPairs = 0;
		int highestValue = 0;

		foreach (KeyValuePair<int, int> group in groupedCards)
		{
			// group.Value = the count, not the Card Value!
			if (group.Value == 2)
			{
				countPairs++;

				// group.Key = the Card Value.
				if (group.Key > highestValue)
					highestValue = group.Key;
			}
		}

		if (countPairs == 2)
		{
			return (200 + highestValue);
		}
		else return 0;
	}


	/// <summary>
	/// Three of a kind: three cards have same Value.
	/// </summary>
	/// <returns>Score of 300 + value of the cards in that pair.</returns>
	public static int ThreeOfAKind(Hand hand)
	{
		int pairValue = SomeOfAKind(hand, 3);
		if (pairValue != 0)
		{
			return (300 + pairValue);
		}
		else return 0;
	}


	/// <summary>
	/// Straight: all card values are in order.
	/// </summary>
	/// <returns>Score of 400 + value of the cards in that pair.</returns>
	public static int Straight(Hand hand)
	{
		int expectedValue = hand.Cards[0].Value;
		int highestValue = 0;

		foreach (Card card in hand.Cards)
		{
			// Since the hand is always sorted, the Values should be in order.
			// Ex: 3, 4, 5, 6, 7
			if (card.Value != expectedValue)
				return 0;

			highestValue = expectedValue;
			expectedValue++;
		}
		return (400 + highestValue);
	}


	/// <summary>
	/// Flush: all cards have the same face.
	/// </summary>
	/// <returns>Score of 500 + value of the cards in that pair.</returns>
	public static int Flush(Hand hand)
	{
		char cardFace = hand.Cards[0].Face;
		int highestValue = 0;

		foreach (Card card in hand.Cards)
		{
			if (card.Face != cardFace)
				return 0;

			if (card.Value > highestValue)
				highestValue = card.Value;
		}
		
		return (500 + highestValue);
	}


	/// <summary>
	/// Full House: Three of a Kind and One Pair together.
	/// </summary>
	/// <returns>Score of 600 + value of the cards in that pair.</returns>
	public static int FullHouse(Hand hand)
	{
		Dictionary<int, int> groupedCards = GroupCardsByValue(hand);
		bool hasThree = false, hasTwo = false;
		int highestValue = 0;

		foreach (KeyValuePair<int, int> group in groupedCards)
		{
			// group.Value = the count, not the Card Value!
			if (group.Value == 3)
				hasThree = true;
			else if (group.Value == 2)
				hasTwo = true;

			// group.Key = the Card Value.
			if (group.Key > highestValue)
				highestValue = group.Key;
		}

		if (hasThree && hasTwo)
		{
			return (600 + highestValue);
		}
		else return 0;
	}


	/// <summary>
	/// Four of a kind: three cards have same Value.
	/// </summary>
	/// <returns>Score of 700 + value of the cards in that pair.</returns>
	public static int FourOfAKind(Hand hand)
	{
		int pairValue = SomeOfAKind(hand, 4);
		if (pairValue != 0)
		{
			return (700 + pairValue);
		}
		else return 0;
	}


	/// <summary>
	/// Straight Flush: all cards same face, values are in order.
	/// </summary>
	/// <returns>Score of 800 + value of the cards in that pair.</returns>
	public static int StraightFlush(Hand hand)
	{
		if (Straight(hand) > 0 && Flush(hand) > 0)
		{
			int highestValue = HighestCard(hand);
			return (800 + highestValue);
		}
		else return 0;
	}


	/// <summary>
	/// Royal Flush: all cards same face, values: 10, J, Q, K, A.
	/// </summary>
	/// <returns>Score of 900.</returns>
	public static int RoyalFlush(Hand hand)
	{
		char cardFace = hand.Cards[0].Face;
		int expectedValue = 10;

		foreach (Card card in hand.Cards)
		{
			if (card.Face != cardFace)
				return 0;

			// Since the hand is always sorted, the Values should be in order of: 
			// 10, 11, 12, 13, 14
			if (card.Value != expectedValue)
				return 0;

			expectedValue++;
		}
		return 900;
	}


	/// <summary>
	/// One pair: two cards have the same Value.
	/// Three of a kind: three cards have same Value.
	/// Four of a kind: four cards have same Value.
	/// </summary>
	/// <returns>Card Value of that Pair/Kind, or 0 if not found</returns>
	private static int SomeOfAKind(Hand hand, int amount)
	{
		Dictionary<int, int> groupedCards = GroupCardsByValue(hand);
		int highestValue = 0;

		foreach (KeyValuePair<int, int> group in groupedCards)
		{
			// group.Value = the count, not the Card Value!
			// group.Key = the actual card Value
			if (group.Value >= amount)
			{
				highestValue = group.Key;
			}
		}

		return highestValue;
	}


	/// <summary>
	/// Counts how many cards of each value are in the hand.
	/// Ex. A hand of 3, 5, 5, 9, 9 will be grouped like this:
	/// | 3 , 1 | 
	/// | 5 , 2 |
	/// | 9 , 2 |
	/// </summary>
	private static Dictionary<int, int> GroupCardsByValue(Hand hand)
	{
		Dictionary<int, int> cardCounts = new Dictionary<int, int>();

		foreach (Card card in hand.Cards)
		{
			// if this Card Value already exists, increase the count;
			// otherwise add it and set it to a count of 1.
			if (cardCounts.ContainsKey(card.Value))
			{
				cardCounts[card.Value]++;
			}
			else
			{
				cardCounts.Add(card.Value, 1);
			}
		}

		return cardCounts;
	}
}
