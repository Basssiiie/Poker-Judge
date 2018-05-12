using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PokerGameFile
{
	private const string fileHeader = "public static partial class Poker\r\n{\r\n\tpublic static string[] Game =\r\n\t{";
	private const string fileFooter = "\t};\r\n}";

	private string name;
	private string path;
	private StreamWriter file;

	public PokerGameFile(string fileName)
	{
		name = fileName + ".cs";
		path = Path.Combine(Application.dataPath, name);

		if (File.Exists(path))
		{
			File.Delete(path);
			Debug.LogFormat("File {0} is deleted!", fileName);
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
