using System;

namespace Indentation
{
	class MainClass
	{
		public static int MySuperMethodOfTheDeath(int fourtyTwo)
		{
			if (fourtyTwo > 0) 
			{
				// ACDC > ASM
				Console.WriteLine ("Print something");
				return 42;
			} 
			else 
			{
				return fourtyTwo;
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			MySuperMethodOfTheDeath(2);
		}

	}
}
