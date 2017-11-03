using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            string document = "PRZYKLADOWY TEKST";
            char[] CharsInDocument = document.ToCharArray();

            ConsoleColor[] colors = new ConsoleColor[CharsInDocument.Length];

            for (int i = 0; i < CharsInDocument.Length; i++)
            {
                colors[i] = ConsoleColor.White;
                if (i % 2 != 0)
                {
                    colors[i] = ConsoleColor.Green;
                }
            }

            CharsFactory CharsFactory = new CharsFactory();

            for (int i = 0; i < CharsInDocument.Length; i++)
            {
                Console.ForegroundColor = colors[i];
                Char letter = CharsFactory.GetChar(CharsInDocument[i]);
                letter.DisplayText();
            }

            Console.WriteLine("\nLiczba powtarzajacych sie znakow: "+CharsFactory.NumberRepeatingChars);

            Console.ReadKey();
        }
    }
}
