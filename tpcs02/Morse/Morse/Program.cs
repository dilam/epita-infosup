using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {
			if (args.Length == 1)
            {
                string result = Translate(int.Parse(args[0]));
                Console.WriteLine("\n{0}", result);
            }
            else
				Console.Error.WriteLine("Invalid number of parameter (must be 1)");
        }

        #region LetterToMorse
        static string LetterToMorse(char c)
        {
            switch(c)
            {
                case 'a':
                case 'A':
                    return ".-";
                case 'b':
                case 'B':
                    return "-...";
                case 'c':
                case 'C':
                    return "-.-.";
                case 'd':
                case 'D':
                    return "-..";
                case 'e':
                case 'E':
                    return ".";
                case 'f':
                case 'F':
                    return "..-.";
                case 'g':
                case 'G':
                    return "--.";
                case 'h':
                case 'H':
                    return "....";
                case 'i':
                case 'I':
                    return "..";
                case 'j':
                case 'J':
                    return ".---";
                case 'k':
                case 'K':
                    return "-.-";
                case 'l':
                case 'L':
                    return ".-..";
                case 'm':
                case 'M':
                    return "--";
                case 'n':
                case 'N':
                    return "-.";
                case 'o':
                case 'O':
                    return "---";
                case 'p':
                case 'P':
                    return ".--.";
                case 'q':
                case 'Q':
                    return "--.-";
                case 'r':
                case 'R':
                    return ".-.";
                case 's':
                case 'S':
                    return "...";
                case 't':
                case 'T':
                    return "-";
                case 'u':
                case 'U':
                    return "..-";
                case 'v':
                case 'V':
                    return "...-";
                case 'w':
                case 'W':
                    return ".--";
                case 'x':
                case 'X':
                    return "-..-";
                case 'y':
                case 'Y':
                    return "-.--";
                case 'z':
                case 'Z':
                    return "--..";
                case ' ':
                    return "/";
                case '0':
                    return "-----";
                case '1':
                    return ".----";
                case '2':
                    return "..---";
                case '3':
                    return "...--";
                case '4':
                    return "....-";
                case '5':
                    return ".....";
                case '6':
                    return "-....";
                case '7':
                    return "--...";
                case '8':
                    return "---..";
                case '9':
                    return "----.";
                default:
                    return c.ToString();
            }
        }
        #endregion

        static string Translate(int n)
        {
            if (n == 0)
                return "";

            return LetterToMorse(Console.ReadKey().KeyChar) + " " + Translate(--n);
        }

		static char MorseToLetter(string s)
		{
			switch(s)
			{
			case ".-":
				return 'a';
			case "-...":
				return 'b';
			case "-.-.":
				return 'c';
			case "-..":
				return 'd';
			case ".":
				return 'e';
			case "..-.":
				return 'f';
			case "--.":
				return 'g';
			case "....":
				return 'h';
			case "..":
				return 'i';
			case ".---":
				return 'j';
			case "-.-":
				return 'k';
			case ".-..":
				return 'l';
			case "--":
				return 'm';
			case "-.":
				return 'n';
			case "---":
				return 'o';
			case ".--.":
				return 'p';
			case "--.-":
				return 'q';
			case ".-.":
				return 'r';
			case "...":
				return 's';
			case "-":
				return 't';
			case "..-":
				return 'u';
			case "...-":
				return 'v';
			case ".--":
				return 'w';
			case "-..-":
				return 'x';
			case "-.--":
				return 'y';
			case "--..":
				return 'z';
			case "/":
				return ' ';
			case "-----":
				return '0';
			case ".----":
				return '1';
			case "..---":
				return '2';
			case "...--":
				return '3';
			case "....-":
				return '4';
			case ".....":
				return '5';
			case "-....":
				return '6';
			case "--...":
				return '7';
			case "---..":
				return '8';
			case "----.":
				return '9';
			default:
				return Convert.ToChar(s);
			}
		}

		static string TranslateToLatin(string s)
		{
			int len = s.Length;
			string result = "";

			for(int i = 0; i < len; i++)
			{
				string part = "";
				while (i < len && s[i] != ' ')
				{
					part += s [i];
					i++;
				}
				result += MorseToLetter (part);
				i++;
			}

			return result;
		}
    }
}
