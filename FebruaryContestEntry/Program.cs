using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';		
		const int columns = 30;
		const int rows = 15;
		const int size = rows * columns;

		static void Main(string[] args)
		{
			// The solution implementation goes here
			int counter = 0;
			while(counter < size)
			{ 				
				PrintBlock(counter % columns, GetConsoleColor(counter % columns, counter / columns));
				counter++;
			}
			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}
		private static ConsoleColor GetConsoleColor(int xCordinate, int yCordinate)
			=> (xCordinate == 0 || xCordinate == columns - 1 || yCordinate == 0 || yCordinate == rows - 1)
			? ConsoleColor.Green
			: ConsoleColor.Yellow;
		private static void PrintBlock(int xCoordinate, ConsoleColor blockColor)
		{
			Console.ForegroundColor = blockColor;
			Console.Write(block);
			if (xCoordinate == columns - 1)
				Console.WriteLine();
		}
	}
}
