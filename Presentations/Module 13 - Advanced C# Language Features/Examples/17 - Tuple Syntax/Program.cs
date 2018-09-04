using System;

namespace Wincubate.Module13.Slide17
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("Please input a word: ");
            string input = Console.ReadLine();

            var t = FindVowels(input);
            Console.WriteLine($"There are {t.Item1} vowels and {t.Item2} consonants in \"{input}\"");
        }

        static (int, int) FindVowels( string s )
        {
            int v = 0;
            int c = 0;

            foreach (char letter in s)
            {
                if (IsVowel(letter))
                {
                    v++;
                }
                else if (char.IsLetter(letter))
                {
                    c++;
                }
            }

            return (v, c);
        }

        static bool IsVowel( char letter )
        {
            switch (char.ToLower(letter))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                case 'æ':
                case 'ø':
                case 'å':
                    return true;
                default:
                    return false;
            }
        }
    }

}
