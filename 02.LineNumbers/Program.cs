using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("../../../text.txt");
            using StreamWriter writer = new StreamWriter("../../../output.txt");
            string line = reader.ReadLine();
            int row = 1;
            while (line != null)
            {
                writer.WriteLine($"{row}.{line}");
                row++;
                line = reader.ReadLine();
            }
        }
    }
}