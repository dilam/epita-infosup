using System;

namespace Parameters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}

		static void Swap(ref int a, ref int b)
		{
			int c = a;
			a = b;
			b = c;
		}

		static int Div(ref int a, int b)
		{
			if (b == 0)
				return -1;
			a = a / b;
			return a % b;
		}

		static bool Mod(ref int a, int b)
		{
			if (b == 0)
				return false;
			a = a % b;
			return true;
		}

		static int Sum(params int[] arr)
		{
			int lon = arr.Length;
			int res = 0;

			for (int i = 0; i < lon; i++)
				res += arr [i];

			return res;
		}
	}
}
