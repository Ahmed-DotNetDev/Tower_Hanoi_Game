namespace Game
{
	public class TowersOfHanoi
	{
		public static void Main(String[] args)
		{
			char firstPeg = 'A';
			char lastPeg = 'C';
			char tempPeg = 'B';
			int totalDisks = 3;

			//Calling methods
			Helper.rearrangement(totalDisks, firstPeg, lastPeg, tempPeg);
		}
	}
	public class Helper
	{
		/// <summary>
		/// This method is rearrangement the tower 
		/// </summary>
		/// <param name="n">Number of disks</param>
		/// <param name="firstPeg">Peg1</param>
		/// <param name="lastPeg">Peg2</param>
		/// <param name="tempPeg">Peg3</param>
		public static void rearrangement(int n, char firstPeg, char lastPeg, char tempPeg)
		{
			if (n > 0)
			{
				rearrangement(n - 1, firstPeg, tempPeg, lastPeg);
				Console.WriteLine("Move disk from " + firstPeg + ' ' + lastPeg);
				rearrangement(n - 1, tempPeg, lastPeg, firstPeg);
			}
		}
	}
}