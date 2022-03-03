using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograms
{
    public class AlphabetVowelOrConsonant
    {
        public void AlphabetVowelOrConsonantMethod(char ch)
        {
            Console.WriteLine("Enter an Alphabet: ");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is a Vowel.");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is a Vowel.");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is a Vowel.");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is a Vowel.");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is a Vowel.");
                    break;
                case 'A':
                    Console.WriteLine("The Alphabet is a Vowel.");
                    break;
                case 'E':
                    Console.WriteLine("The Alphabet is a Vowel.");
                    break;
                case 'I':
                    Console.WriteLine("The Alphabet is a Vowel.");
                    break;
                case 'O':
                    Console.WriteLine("The Alphabet is a Vowel.");
                    break;
                case 'U':
                    Console.WriteLine("The Alphabet is a Vowel.");
                    break;
                default:
                    Console.WriteLine("The Alphabet is a Consonant.");
                    break;
            }
        }
    }
}
