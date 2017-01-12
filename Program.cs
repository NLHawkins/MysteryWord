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
        static void DrawBoard(List<string> letterList)
        {
            foreach (string letter in letterList)
                Console.WriteLine("_ ");
        }

       


        
            
            static void Main(string[] args)
        {
            Console.WriteLine("Let's Play Mystery Word");

             
            string[] wordArray;
            wordArray = File.ReadAllLines(@"..\..\WordList.txt");
            List<string> wordList = wordArray.ToList<string>();
            var rwg = new Random();
            int rndmNumb = rwg.Next(wordList.Count);

            string mystWord = (wordList[rndmNumb]);
            Console.WriteLine(mystWord);

            var mystWordCharList = mystWord.Split("");





        }
    }
}
