using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morseCodeTranslator
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Morse Code translator v1.0\n");
            
            string userInput = "";
            string translatedString = "";

            while (userInput != "exit")
            {
                Console.WriteLine("Enter an English phrase to be translated to Morse Code:");
                Console.WriteLine("(Only alphanumeric characters in International Morse Code, type 'exit' to quit program)");
                userInput = Console.ReadLine();

                if (userInput.ToLower() != "exit")
                {
                    char[] chars = userInput.ToUpper().ToCharArray();
                    StringBuilder sb = new StringBuilder();
                    foreach (char engChar in chars)
                    {
                        sb.Append(LatinToMorse(engChar));
                        sb.Append(" ");
                    }
                    translatedString = sb.ToString().Trim();
                    System.Windows.Forms.Clipboard.SetText(translatedString);
                    Console.WriteLine("\"{0}\" was copied to the clipboard", translatedString);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Goodbye");
        }

        static string LatinToMorse(char latinChar)
        {
            switch (latinChar)
            {
                //letters
                case 'A':
                    return "·-";
                    break;
                case 'B':
                    return "-····";
                    break;
                case 'C':
                    return "-·-·";
                    break;
                case 'D':
                    return "-··";
                    break;
                case 'E':
                    return "·";
                    break;
                case 'F':
                    return "··-·";
                    break;
                case 'G':
                    return "--·";
                    break;
                case 'H':
                    return "····";
                    break;
                case 'I':
                    return "··";
                    break;
                case 'J':
                    return "·---";
                    break;
                case 'K':
                    return "-·-";
                    break;
                case 'L':
                    return "·-··";
                    break;
                case 'M':
                    return "--";
                    break;
                case 'N':
                    return "-·";
                    break;
                case 'O':
                    return "---";
                    break;
                case 'P':
                    return "·--·";
                    break;
                case 'Q':
                    return "--·-";
                    break;
                case 'R':
                    return "·-·";
                    break;
                case 'S':
                    return "···";
                    break;
                case 'T':
                    return "-";
                    break;
                case 'U':
                    return "··-";
                    break;
                case 'V':
                    return "···-";
                    break;
                case 'W':
                    return "·--";
                    break;
                case 'X':
                    return "-··-";
                    break;
                case 'Y':
                    return "-·--";
                    break;
                case 'Z':
                    return "--··";
                    break;

                //numbers
                case '1':
                    return "·----";
                    break;
                case '2':
                    return "··---";
                    break;
                case '3':
                    return "···--";
                    break;
                case '4':
                    return "····-";
                    break;
                case '5':
                    return "·····";
                    break;
                case '6':
                    return "-····";
                    break;
                case '7':
                    return "--···";
                    break;
                case '8':
                    return "---··";
                    break;
                case '9':
                    return "----·";
                    break;
                case '0':
                    return "-----";
                    break;

                case ' ':
                    return " ";

                default:
                    return "";
                    break;
            }
        }
    }
}
