using System;

namespace Connect4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Veuillez entrer les dimensions de la grille de jeu.");
			Console.Write ("Hauteur: ");
			int x = Convert.ToInt32(Console.ReadLine ());
			Console.Write ("Longueur: ");
			int y = Convert.ToInt32(Console.ReadLine ());

			char[,] grid = CreateGrid (x, y);
			int add = 0;
			bool player = false;

			while (add == 0)
			{
				int i = CheckInput (grid) - 1;

				add = AddToken (grid, i, player);
				if(add == -1)
				{
					int j = 0;
					while (j < y && grid[0, j] != '-')
						j++;
					if (j < y)
						add = 0;
				}
				if(add == 0)
					player = !player;
			}
			Console.Clear ();
			Print (grid, 0);
			if (add == -1)
				Console.WriteLine("La grille est pleine.");
			if (add == 1)
				Console.WriteLine("Player " + (player ? "X" : "O") + " Win !!!");
		}

		static char[,] CreateGrid(int x, int y)
		{
			char[,] grid = new char[x, y];

			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < y; j++)
					grid[i,j] = '-';
			}

			return grid;
		}

		static void Print(char[,] grid, int cursor)
		{
			int lonX = grid.GetLength (0);
			int lonY = grid.GetLength (1);

			for (int i = 0; i < cursor; i++)
				Console.Write ("  ");
			Console.WriteLine ("|");

			for (int i = 0; i < lonX; i++)
			{
				Console.Write("|");
				for (int j = 0; j < lonY; j++)
					Console.Write (" " + grid [i, j]);
				Console.WriteLine (" |");
			}

			for (int i = 0; i < lonY; i++)
				Console.Write ("--");
			Console.WriteLine ("---");
		}

		static int CheckInput(char[,] grid)
		{
			int cursor = 1;
			int maxCursor = grid.GetLength (1);
			bool enter = false;
			ConsoleKeyInfo touch;

			while (!enter) {
				Console.Clear ();
				Print(grid, cursor);

				touch = Console.ReadKey (true);

				enter = touch.Key == ConsoleKey.Enter;

				if (touch.Key == ConsoleKey.LeftArrow)
					cursor -= (cursor == 1) ? 0 : 1;
				
				if (touch.Key == ConsoleKey.RightArrow)
					cursor += (cursor == maxCursor) ? 0 : 1;
			}

			return cursor;
		}

		static bool CheckLine(char[,] grid, int h, bool player)
		{
			int lonY = grid.GetLength (1) - 3;
			int i = 0;
			bool win = false;

			while (!win && i < lonY)
			{
				win = (grid[h, i]     != '-'
					&& grid[h, i]     == grid[h, i + 1] 
					&& grid[h, i + 1] == grid[h, i + 2]
					&& grid[h, i + 2] == grid[h, i + 3]);
				i++;
			}

			return win;
		}

		static bool CheckColumn(char[,] grid, int w, bool player)
		{
			int lonX = grid.GetLength (0) - 3;
			int i = 0;
			bool win = false;

			while (!win && i < lonX)
			{
				win = (grid [i, w]     != '-'
					&& grid [i, w]     == grid [i + 1, w]
					&& grid [i + 1, w] == grid [i + 2, w]
					&& grid [i + 2, w] == grid [i + 3, w]);
				i++;
			}

			return win;
		}

		static bool CheckDiagonal(char[,] grid, int h, int w, bool player)
		{
			//int lonX = grid.GetLength (0);
			//int lonY = grid.GetLength (1);

			int i = h - 3;
			int j = w - 3;

			if (i < 0)
			{
				
			}

			int iMax = h + 4;
			int jMax = w + 4;
			
			bool win = false;

			while (!win && i + 3 < iMax && j + 3 < jMax )
			{
				win = (grid [i, j]         == grid [i + 1, j + 1]
					&& grid [i + 1, j + 1] == grid [i + 2, j + 2]
					&& grid [i + 2, j + 2] == grid [i + 3, j + 3]);
				i++;
				j++;
			}

			//while (!win && iMax - 3 > 0)

			return win;
		}

		static bool CheckWin(char[,] grid, int h, int w, bool player)
		{
			return CheckLine(grid, h, player) 
				|| CheckColumn(grid, w, player);
				//|| CheckDiagonal(grid, h, w, player);
		}

		static int AddToken(char[,] grid, int i, bool player)
		{
			if(grid[0, i] != '-')
				return -1;

			int lonX = grid.GetLength (0) - 1;

			while (lonX > 0 && grid [lonX, i] != '-')
				lonX--;

			grid[lonX, i] = player ? 'X' : 'O';

			return CheckWin (grid, lonX, i, player) ? 1 : 0;
		}
	}
}
