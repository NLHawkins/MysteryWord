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
            int gameCounter = 0;
            bool contGame = true;

            Console.WriteLine(mystWord);

            while (gameCounter == 0)
            {
                if (gameCounter == 0)
                    for (int i = 0; i < mystWord.Length; i++)
                    {
                        string blank = "_";
                        mystWordBlanks[i] = blank;
                        
                        
                    }
               
                Console.WriteLine(string.Join(" ", mystWordBlanks));
               
                Console.WriteLine("Guess a Letter");
                string guessString = Console.ReadLine();
                Console.Clear();
                char guess = guessString[0];



                for (int i = 0; i < mystWord.Length; i++)
                {
                    string blank = "_";
                    mystWordBlanks[i] = blank;
                    

                    if (mystWordCharArray[i] == guess)
                    {
                        mystWordBlanks[i] = guess.ToString();
                        
                    }
                    
                }
                Console.WriteLine(string.Join(" ", mystWordBlanks));
                gameCounter = 1;
                //contGame = false;




            }





            //************************************

            //Console.WriteLine(mystWord);

            //***********************************











        }
    }
}
