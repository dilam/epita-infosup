using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Hello (string str)
        {
            Console.WriteLine((str == "") ? "Hello World!" : "Hello {0}!", str);
        }

        static void HelloWorldErr()
        {
            Console.Error.WriteLine("Hello World!");
        }

        static void ImportantHello()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("This is an important announcement: Hello World!");

            Console.ResetColor();
        }
    }
}
