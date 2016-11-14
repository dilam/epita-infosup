using System;

namespace PlayWithTypes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// We need fact
			Console.WriteLine (Fact(0));
			Console.WriteLine (Fact(5));
			Console.WriteLine (Fact(10));

			// Pow-er rangers incoming!
			Console.WriteLine (Pow(1, 2));
			Console.WriteLine (Pow(2, 2));
			Console.WriteLine (Pow(2, 10));

			// Hello ...!
			HelloName("Edgar");
			HelloName("My beloved ACDC");
			HelloName("Mister Bond");

			// Even or odd
			EvenOdd(0);
			EvenOdd(53);
			EvenOdd(1234567890);

			// Differents angles
			Console.WriteLine (DegToRad(1));
			Console.WriteLine (DegToRad(53));
			Console.WriteLine (RadToDeg(1F));
			Console.WriteLine (RadToDeg(5F));
		}

		public static int Fact(int n)
		{
			if (n < 0)
				return -1;

			if (n < 2)
				return 1;
			else
				return n * Fact (n - 1);
		}

		public static int Pow(int x, int y)
		{
			if (y < 0)
				return 0;

			if (y < 2)
				return x;
			else
				return x * Pow (x, y - 1);
		}

		public static void HelloName(string name)
		{
			Console.WriteLine ("Hello " + name + "!");
		}

		public static void EvenOdd(int x)
		{
			if (x % 2 == 0)
				Console.WriteLine (x + " is even");
			else
				Console.WriteLine (x + " is odd");
		}

		public static float DegToRad(float x)
		{
			return (float)Math.PI * x / 180;
		}

		public static float RadToDeg(float x)
		{
			return 180 * x / (float)Math.PI;
		}
	}
}
