using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace LA1300
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                string titel = @"
███████████████████████████████████████████████████████████████████████████████████████████████████
█▄─█─▄█─▄▄─█─▄▄▄─██▀▄─██▄─▄─▀█▄─██─▄█▄─▄████▀▄─██▄─▄▄▀█▄─█─▄███─▄─▄─█▄─▄▄─█─▄▄▄▄█─▄─▄─█▄─▄▄─█▄─▄▄▀█
██▄▀▄██─██─█─███▀██─▀─███─▄─▀██─██─███─██▀██─▀─███─▄─▄██▄─▄██████─████─▄█▀█▄▄▄▄─███─████─▄█▀██─▄─▄█
▀▀▀▄▀▀▀▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▀▄▄▄▀▀▀▀▀▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀▄▄▀▄▄▀
";
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(titel);



                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Welcome to the Vocabulary Tester.");
                Console.WriteLine("Im gonna ask you 20 words and you need to translate them.");
                Console.WriteLine("I hope you can enjoy and learn much! :)");

            }

            string inPath = @"C:Vokabeln.csv";
            string text = File.ReadAllText(inPath);



            string[] lines = text.Split("\r\n");
            int words = lines.Length;
            string[] english = new string[words];
            string[] german = new string[words];



            for (int line = 0; line < lines.Length - 1; line++)
            {
                string[] items = lines[line].Split(',');
                english[line] = items[0];
                german[line] = items[1].Replace("\"", string.Empty); ;
            }



            WriteLine("\r\nAvailable languages:\r\n[1] German\r\n[2] English\r\n\nWhich language should be asked for? ^.^ ");
            int userInput;
            int language = -1;
            while (language == -1)
            {
                try
                {
                    userInput = Convert.ToInt32(ReadLine());
                    if (userInput != 1 && userInput != 2)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        if (userInput == 1)
                        {
                            language = 1;
                        }
                        else
                        {
                            language = 2;
                        }
                    }
                }
                catch
                {
                    WriteLine("Wrong input!-_-");
                }
            }
            Clear();


            if (language == 1)
            {

                List<int> incorrect = new List<int>();
                while (incorrect.Count < 20)
                {
                    int newWord = new Random().Next(0, english.Length);
                    if (!incorrect.Contains(newWord))
                    {
                        incorrect.Add(newWord);
                    }
                }

                while (incorrect.Count != 0)
                {
                    int numbers = incorrect.Count;
                    int minus = 0;
                    for (int item = 0; item < numbers; item++)
                    {
                        Console.Write("Gib die Übersetzung von \"" + german[incorrect[item - minus]] + "\" ein.\n");
                        if (english[incorrect[item - minus]] != Console.ReadLine())
                        {
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("Falsch.(π.π\") Die richtige Antwort ist " + english[incorrect[item - minus]] + ". Drücke Enter um fortzufahren.");
                            ReadLine();
                            Clear();
                            ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.WriteLine("Richtig. Drücke Enter um fortzufahren. (^o^)/");
                            incorrect.RemoveAt(item - minus);
                            minus++;

                            ReadLine();
                            Clear();
                        }
                    }
                }

            }
            if (language == 2)
            {
                List<int> incorrect = new List<int>();
                while (incorrect.Count < 20)
                {
                    int newWord = new Random().Next(0, german.Length);
                    if (!incorrect.Contains(newWord))
                    {
                        incorrect.Add(newWord);
                    }
                }

                while (incorrect.Count != 0)
                {
                    int numbers = incorrect.Count;
                    int minus = 0;
                    for (int item = 0; item < numbers; item++)
                    {
                        Console.Write("Enter the translation of \"" + english[incorrect[item - minus]] + "\". (~ ° w°)~\n");
                        if (german[incorrect[item - minus]] != Console.ReadLine())
                        {
                            ForegroundColor = ConsoleColor.Red;
                            WriteLine("False. π.π The right answer is " + german[incorrect[item - minus]] + ". Enter to continue.");

                            ReadLine();
                            Clear();
                            ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.WriteLine("Right. Enter to continue.(^.^)/ ");
                            incorrect.RemoveAt(item - minus);
                            minus++;
                            ReadLine();
                            Clear();
                        }
                    }
                }
            }
        }
    }
}