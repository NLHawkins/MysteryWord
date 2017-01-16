using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play Mystery Word");

            string[] wordArray;
            wordArray = File.ReadAllLines(@"..\..\MystWordList.txt");
            List<string> wordList = wordArray.ToList<string>();
            var rwg = new Random();
            int rndmNumb = rwg.Next(wordList.Count);
            string mystWord = wordList[rndmNumb];
            string[] mystWordBlanks = new string[mystWord.Length];
            char[] mystWordCharArray = mystWord.ToCharArray();
            List<string> guessedLetters = new List<string>();

            int guessLeft = 8;
            int blanksChanged = 0;

            for (int i = 0; i < mystWord.Length; i++)
            {
                string blank = "_";
                mystWordBlanks[i] = blank;
            }

            Console.WriteLine(string.Join(" ", mystWordBlanks));

            while ((string.Join("", mystWordBlanks) != mystWord) && (guessLeft > 0))
            {                
                blanksChanged = 0;
                Console.WriteLine("Guess a Letter");                
                string guessString = Console.ReadLine().ToLower();
                Console.Clear();
                char guess = guessString[0];
                if (guessedLetters.Contains(guessString))
                {
                    Console.WriteLine("This letter has been previously guessed");
                    Console.WriteLine("Guess a new letter");
                }
                guessedLetters.Add(guessString);

                for (int i = 0; i < mystWord.Length; i++)
                {
                    if (mystWordCharArray[i] == guess)
                    {
                        mystWordBlanks[i] = guess.ToString();
                        blanksChanged++;
                    }
                }

                Console.WriteLine(string.Join(" ", mystWordBlanks));
                Console.WriteLine("Letters Guessed");
                guessedLetters.ForEach(Console.WriteLine);

                if (blanksChanged == 0)
                {
                    guessLeft--;
                    Console.WriteLine($"Incorrect Guess! You have {guessLeft} guesses remaining");
                }

            }
            if (string.Join("", mystWordBlanks) == mystWord)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                Console.WriteLine("You're a LOSER");
                Console.WriteLine($"The Mystery Word was {mystWord}");
            }
        }
    }
}

