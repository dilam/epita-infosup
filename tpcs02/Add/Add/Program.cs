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
            try
            {
                Console.WriteLine(int.Parse(args[0]) + int.Parse(args[1]));
            }
            catch
            {
                Console.WriteLine("Invalid number of operands");
            }

            Console.ReadLine();
        }
    }
}
