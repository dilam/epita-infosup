using System;

namespace PrintHouse
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PrintHouse (10);
		}

		public static void Smoke(int x)
		{
			if (x < 0)
				Console.Write ();
			else if (x % 2 == 0)
				Console.Write ("    ( (");
			else
				Console.Write ("    ) )");
			
			Console.WriteLine ();
		}

		public static void Roof(int x)
		{
			if (x < 0)
				Console.Write ("       ");
			else if (x % 2 == 0)
				Console.Write ("    ) )");
			else
				Console.Write ("    ( (");

			Console.WriteLine ("        /\\\n   =====      /  \\\n  _|___|_____/ __ \\____________\n |::::::::::/ |  | \\:::::::::::|\n |:::::::::/  ====  \\::::::::::|\n |::::::::/__________\\:::::::::|\n |_________|  ____  |__________|");
		}

		public static void Floor()
		{
			Console.WriteLine ("  | ______ | / || \\ | _______ |\n  ||  |   || ====== ||   |   ||\n  ||--+---|| |    | ||---+---||\n  ||__|___|| |   o| ||___|___||\n  |========| |____| |=========|");
		}

		public static void Ground()
		{
			Console.WriteLine (" (^^-^^^^^-|________|-^^^--^^^)\n (,, , ,, ,/________\\,,,, ,, ,)\n','',,,,' /__________\\,,,',',;;");
		}

		public static void PrintHouse(int x)
		{
			if (x < 0) 
			{
				Console.Clear ();
				Smoke (x);
				Roof (x);
				Floor ();
				Ground ();
			}
			else 
			{
				Console.Clear ();
				Smoke (x);
				Roof (x);
				Floor ();
				Ground ();
				System.Threading.Thread.Sleep(1000);
				PrintHouse (x - 1);
			}
		}
	}
}
