using System;
using System.Linq;
using System.Collections.Generic;

namespace LetterChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();
            Console.WriteLine(LetterChanger(input));
            Console.ReadLine();
        }

        public static string LetterChanger(string str)
        {       
            List<char> alphabet = new List<char>("abcdefghijklmnopqrstuvwxyz".ToCharArray());
            char[] vowels = "aeiou".ToCharArray();
            string[] strs = str.ToLower().Split(' ');
            
            for (int w=0;w<strs.Length;w++)
            {
                List<char> letters = new List<char>(strs[w].ToCharArray());
                for (int l=0;l<letters.Count;l++)
                {                   
                    if (alphabet.Contains(letters[l]))
                    {
                        letters[l] = alphabet[alphabet.IndexOf(letters[l]) + 1];
                        if (vowels.Contains(letters[l]))
                        {
                            letters[l] = char.ToUpper(letters[l]);
                        }
                    }
                }
                strs[w] = String.Join("", letters);
            }
            str = String.Join(" ", strs);
            return str;
        }
    }
}
