using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PokerGameFile
{
	private const string fileHeader = "public static class Poker\r\n{\r\n\tpublic static string[] Game =\r\n\t{";
	private const string fileFooter = "\t};\r\n}";

	private string name;
	private string path;
	private StreamWriter file;


	/// <summary>
	/// Note that you still need to let Unity recompile the C# code before it recognizes a new 
	/// file has been created.
	/// </summary>
	public PokerGameFile(string inputName)
	{
		name = Path.ChangeExtension(inputName, ".cs");
		path = Path.Combine(Application.dataPath, name);

		if (File.Exists(path))
		{
			File.Delete(path);
			Debug.LogFormat("File {0} is deleted!", inputName);
		}

		file = File.CreateText(path);
		file.WriteLine(fileHeader);
	}


	public void Write(PokerRound round)
	{
		string[] hands = new string[round.players.Length];

		for (int p = 0; p < round.players.Length; p++)
		{
			hands[p] = string.Join(" ", round.players[p]);
		}

		file.WriteLine("\t\t\"" + string.Join("|", hands) + "\",");
	}


	public void Save()
	{
		file.WriteLine(fileFooter);
		file.Close();
	}
}
