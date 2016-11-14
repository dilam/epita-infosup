using System;

namespace PrintHouse
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Do you want to see the simple house (1) or the bonii (2)? ");
			string i = Console.ReadLine();
			if (i == "1")
				PrintHouse ();
			else if (i == "2")
				PrintHouse_ (10);
			else
				Console.WriteLine("Invalid response.");
		}

		public static void Roof()
		{
			Console.WriteLine ("  ___________");
			Console.WriteLine (" / | |   | | \\");
			Console.WriteLine ("---------------");
		}

		public static void Floor()
		{
			Console.WriteLine ("|  |0|   |0|  |");
			Console.WriteLine ("|             |");
		}

		public static void Ground()
		{
			Console.WriteLine ("|      _      |");
			Console.WriteLine ("|_____|-|_____|");
		}

		public static void PrintHouse()
		{
			Roof ();
			Floor ();
			Ground ();
		}

		public static void Smoke(int x)
		{
			if (x < 0)
				Console.Write ("");
			else if (x % 2 == 0)
				Console.Write ("    ( (");
			else
				Console.Write ("    ) )");
			
			Console.WriteLine ();
		}

		public static void Roof_(int x)
		{
			if (x < 0)
				Console.Write ("       ");
			else if (x % 2 == 0)
				Console.Write ("    ) )");
			else
				Console.Write ("    ( (");

			Console.WriteLine ("        /\\\n   =====      /  \\\n  _|___|_____/ __ \\____________\n |::::::::::/ |  | \\:::::::::::|\n |:::::::::/  ====  \\::::::::::|\n |::::::::/__________\\:::::::::|\n |_________|  ____  |__________|");
		}

		public static void Floor_()
		{
			Console.WriteLine ("  | ______ | / || \\ | _______ |\n  ||  |   || ====== ||   |   ||\n  ||--+---|| |    | ||---+---||\n  ||__|___|| |   o| ||___|___||\n  |========| |____| |=========|");
		}

		public static void Ground_()
		{
			Console.WriteLine (" (^^-^^^^^-|________|-^^^--^^^)\n (,, , ,, ,/________\\,,,, ,, ,)\n','',,,,' /__________\\,,,',',;;");
		}

		public static void PrintHouse_(int x)
		{
			if (x < 0) 
			{
				Console.Clear ();
				Smoke (x);
				Roof_ (x);
				Floor_ ();
				Ground_ ();
			}
			else 
			{
				Console.Clear ();
				Smoke (x);
				Roof_ (x);
				Floor_ ();
				Ground_ ();
				System.Threading.Thread.Sleep(1000);
				PrintHouse_ (x - 1);
			}
		}
	}
}
