using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Card
{
	public char Face;
	public int Value;


	/// <summary>
	/// Creates a Card instance based on the input.
	/// </summary>
	/// <param name="input">Expected: 2 character long string, with face and value of a card.</param>
	public Card(string input)
	{
		Face = input[0];
		char value = input[1];

		// TryParse will return true if it can change the 'char' 2 into the 'int' 2 or false if it
		// cannot change 'value' into an integer. Once they are all integers, I can easily compare
		// their value.
		if (!int.TryParse(value.ToString(), out Value))
		{
			switch (value)
			{
				case 'T': Value = 10; break;
				case 'J': Value = 11; break;
				case 'Q': Value = 12; break;
				case 'K': Value = 13; break;
				case 'A': Value = 14; break;
			}
		}
	}


	public override string ToString()
	{
		return (Face + Value.ToString());
	}
}
