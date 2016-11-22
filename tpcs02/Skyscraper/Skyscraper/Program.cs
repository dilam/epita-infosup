using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyscraper
{
    class Program
    {
        static void Main(string[] args)
        {
        }

		static Random random = new Random();

		static ConsoleColor GetRandomColor()
		{
			return (ConsoleColor)random.Next(0, 16);
		}

        static void Ground()
        {
            Console.WriteLine(
                "|    ____    |\n" +
                "|___|-||-|___|"
                );
        }

        static void Roof()
        {
            Console.WriteLine(
                " ____________\n" +
                "|            |");
        }

        static void Floor()
        {
            ConsoleColor back = Console.BackgroundColor;
            ConsoleColor fore = Console.ForegroundColor;

            Console.BackgroundColor = GetRandomColor();
            Console.ForegroundColor = GetRandomColor();

            Console.WriteLine(
                "|  |O|  |O|  |\n" +
                "|            |");
            
            Console.BackgroundColor = back;
            Console.ForegroundColor = fore;
        }

        static void Floors(int n)
        {
            if (n > 0)
            {
                Floor();
                Floors(--n);
            }
        }

        static void Skyscraper(int n)
        {
            Roof();
            Floors(n);
            Ground();
        }
    }
}
