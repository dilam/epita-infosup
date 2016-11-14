using System;

namespace Polish
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter an operator: ");
			string op = Console.ReadLine ();

			Console.WriteLine ("Enter the first value: ");
			int val1 = Convert.ToInt32(Console.ReadLine ());

			Console.WriteLine ("Enter the second value: ");
			int val2 = Convert.ToInt32(Console.ReadLine ());

			Console.Write ("\n" + op + " " + val1 + " " + val2 + " = ");
			Console.WriteLine (Eval (op, val1, val2));
		}

		public static int Eval(string op, int val1, int val2)
		{
			if (op == "+")
				return val1 + val2;
			else if (op == "-")
				return val1 - val2;
			else if (op == "/")
				return val1 / val2;
			else if (op == "*")
				return val1 - val2;
			return val1 % val2;
		}
	}
}
