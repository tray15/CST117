using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            string fileLocation = @"E:\GitHub\CST117\Exercise10\Exercise10\TextFile1.txt";
            string text = File.ReadAllText(fileLocation);
            text = Regex.Replace(text, @"[,\!]", "");
            string[] words = text.Split(' ');
            foreach (var word in words)
            {
                if (word.EndsWith('e') || word.EndsWith('t'))
                {
                    counter++;
                }
            }
            Console.WriteLine("There are " + counter + " words that end in t or e");


        }
    }
}
