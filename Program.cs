using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentenceOriginal, longestWord = "";
            int LengthTest = 0;
            string[] individualWords;

            Console.WriteLine("*****************************");
            Console.WriteLine("          Welcome");
            Console.WriteLine("*****************************");

            while (true)
            {
                
                Console.WriteLine("\n\nPlease provide a sentence.");
                sentenceOriginal = Console.ReadLine();

                individualWords = sentenceOriginal.Split(' ');

                int i = 0; //itteration and index counter
                foreach (string words in individualWords)
                {
                    if (words.Length > LengthTest)
                    {
                        LengthTest = words.Length;
                        longestWord = individualWords[i];
                    }

                    i++;
                }
                Console.WriteLine(longestWord + " is the longest word and is " + LengthTest + " characters long");

                Console.ReadKey();
            }
            
            
        }
    }
}
