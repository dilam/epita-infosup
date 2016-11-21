using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JollyRoger
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Skull()
        {
            int i = -1;
            Console.Clear();
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("         _,.--------., _");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("     ,; ~'             '~;,");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("   ,;                     ;,");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("  ;                         ;");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine(" ,'                         ',");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine(",;                           ;,");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("; ;       .          .      ; ;");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("| ;    ______      ______   ; |");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("|  `/ ~\"    ~\" . \"~     \"~\\'  |");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("|  ~  ,-~~~^~, | ,~^~~~-,  ~  |");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine(" |   |        }:{        |   |");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine(" |   l       / | \\       !   |");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine(" .~  (__,.--\" .^. \"--.,__)  ~.");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine(" |     ---;' / | \\ `;---     |");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("  \\__.       \\/^\\/       .__/");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("   V| \\                 / |V");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("    | |T ~\\___!___!___/~T| |");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("    | |`IIII_I_I_I_IIII'| |");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("    |  \\,III I I I III,/  |");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("     \\   `~~~~~~~~~~'    /");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("       \\   .       .   /  ");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("         \\.    ^    ./");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 15, ++i);
            Console.WriteLine("           ^~~~^~~~^");
        }

        static void PrintSkull()
        {
            Skull();

            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Skull();

            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("The code is law");
        }
    }
}
