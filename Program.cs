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

            for (int blanks = 0; blanks < mystWord.Length; blanks++)
            {
                string blank = "_";
                mystWordBlanks[blanks] = blank;
                
            }
            Console.WriteLine(string.Join(" ", mystWordBlanks));

            string[] mystWordFilled = new string[mystWord.Length];

            for (int filledSpot = 0; filledSpot < mystWord.Length; filledSpot++)
            {
                mystWordFilled[filledSpot] = wordArray[filledSpot];
            }

            Console.WriteLine(mystWord);

            char[] mystWordCharArray = mystWord.ToCharArray();
            int letterCount = mystWordCharArray.Length;

            for (int guessCount = 0; guessCount < 8; guessCount++)
            {
               
            }
        }
    }
}
