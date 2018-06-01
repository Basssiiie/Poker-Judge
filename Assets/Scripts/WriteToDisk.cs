public static class WriteToDisk
{
    private static string[] output = new string[1000];


	/// <summary>
	/// Creates a file called "output.txt" in the folder directory.
	/// If you cannot find it, set a full path to the C:\ or D:\ drive.
	/// </summary>
    public static void WriteFileToDisk()
	{ 
        System.IO.File.WriteAllLines(@"output.txt", output);
    }


	/// <summary>
	/// Set the specific round to a winner. (0 = draw, 1 = player 1, 2 = player 2) 
	/// </summary>
	public static void SetOutput(int round, int winner, bool writeHands = false)
	{
		string[] op = { "TIE", "PLAYER1", "PLAYER2"};
		output[round] = string.Format("Round{0} {1}", round, op[winner]);
	}
}
