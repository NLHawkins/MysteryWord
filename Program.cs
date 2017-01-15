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
        /*static void DrawBoard(List<string> letterList)
        {
            foreach (string letter in letterList)
                Console.WriteLine("_ ");
        }*/

        /*static void Drawboard(string[] mystWordBlanks)
    {
        for (int i = 0; i < mystWord.Length; i++)
        {
            mystWordBlanks[i] = "_ ";
        }
    }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play Mystery Word");



            string[] wordArray;
            wordArray = File.ReadAllLines(@"..\..\WordList.txt");
            List<string> wordList = wordArray.ToList<string>();
            var rwg = new Random();
            int rndmNumb = rwg.Next(wordList.Count);

            string mystWord = wordList[rndmNumb];
            string[] mystWordBlanks = new string[mystWord.Length];
            char[] mystWordCharArray = mystWord.ToCharArray();
            List<char> mystWordCharList = mystWordCharArray.ToList();
            int gamePlay = 0;
            bool contGame = true;
            int guessLeft = 8;
            int blanksChanged = 0;

            //Console.WriteLine(mystWord);

            for (int i = 0; i < mystWord.Length; i++)
            {
                string blank = "_";
                mystWordBlanks[i] = blank;
            }

            Console.WriteLine(string.Join(" ", mystWordBlanks));
            gamePlay++;

            while ((string.Join("", mystWordBlanks) != mystWord) && (guessLeft > 0))
            {

                blanksChanged = 0;
                Console.WriteLine("Guess a Letter");
                Console.WriteLine($"You have {guessLeft} incorrect guesses remaining!");
                string guessString = Console.ReadLine();
                Console.Clear();
                char guess = guessString[0];

                for (int i = 0; i < mystWord.Length; i++)
                {
                    if (mystWordCharArray[i] == guess)
                    {
                        mystWordBlanks[i] = guess.ToString();
                        blanksChanged++;
                    }                 
                }
                Console.WriteLine(string.Join(" ", mystWordBlanks));

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
            }

        }
    }
    //contGame = false;

}


    //************************************

    //Console.WriteLine(mystWord);

    //***********************************





