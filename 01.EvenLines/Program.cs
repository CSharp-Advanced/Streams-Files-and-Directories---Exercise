using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charactersToReplace = { '-', ',', '.', '!', '?' };
            using StreamReader reader = new StreamReader("./text.txt");
            using StreamWriter writer = new StreamWriter("../../../output.txt");
            int count = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (count % 2 == 0)
                {
                    line = ReplaceSymbols(charactersToReplace, '@', line);
                    line = Reverse(line);
                    writer.WriteLine(line);
                    Console.WriteLine(line);
                }
                count++;
            }
        }

        private static string Reverse(string line)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] word = line.Split().ToArray();
            for (int i = 0; i < word.Length; i++)
            {
                stringBuilder.Append(word[word.Length - i - 1]);
                stringBuilder.Append(' ');
            }
            return stringBuilder.ToString().TrimEnd();
        }

        private static string ReplaceSymbols(char[] charactersToReplace, char v, string line)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (charactersToReplace.Contains(currentSymbol))
                {
                    sb.Append('@');
                }
                else
                {
                    sb.Append(currentSymbol);
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
