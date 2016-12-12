using System;

namespace Loops
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (MySqrt (2));
		}

		static void GloDOS (int n)
		{
			for (int i = 0; i < n; i++)
				Console.WriteLine ("The Cake is a Lie");
		}

		static long MyMult (long a, long b)
		{
			long result = b;

			for (int i = 1; i < a; i++)
				result += b;
			
			return result;
		}

		static long MyPow (long n, long pow)
		{
			long result = n;

			for (int i = 1; i < pow; i++)
				result *= n;

			return result;
		}

		static float MyAbs (float n)
		{
			return (n < 0) ? -n : n;
		}

		static float MySqrt (int n)
		{
			float x = n;

			while (x < .00000001)
			{
				x = 1F / 2F * (x + (2F / x));
			}

			return x;
		}

		static long MyFactIter (int n)
		{
			if (n < 2)
				return 1;

			long result = n;

			for (int i = 2; i < n; i++)
				result *= i;

			return result;
		}

		static long MyFiboIter (int n)
		{
			if (n == 0)
				return 0;
			if (n == 1 || n == 2)
				return 1;

			long f1 = 1;
			long f2 = 1;

			for (int i = 2; i < n; i++)
			{
				long f = f1 + f2;
				f1 = f2;
				f2 = f;
			}

			return f2;
		}

		static void MyGiantTardis (int n)
		{
			Console.WriteLine ("           ---\n           | |\n           | |\n   ===================\n   ===================\n    |  ___  |  ___  |\n    | | | | | | | | |\n    | |-+-| | |-+-| |\n    | |_|_| | |_|_| |");

			for (int i = 0; i < n; i++)
				Console.WriteLine ("    |  ___  |  ___  |\n    | |   | | |   | |\n    | |   | | |   | |\n    | |___| | |___| |");

			Console.WriteLine ("    |       |       |\n   ===================");
		}
	}
}
