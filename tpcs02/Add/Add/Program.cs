using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
		{
			if (args.Length < 2)
				Console.Error.WriteLine ("Invalid number of operands");
			else
				Console.WriteLine (int.Parse (args [0]) + int.Parse (args [1]));
		}
    }
}
