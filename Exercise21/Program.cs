using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing;
            do
            {
                List<string> sentenceList = new List<string>();

                GetSentenceAndPrint(sentenceList);
                keepGoing = DoAnotherSentence();

            } while (keepGoing);

            Console.WriteLine("Goodbye!!!!");
            Console.ReadKey();
        }

        static public void GetSentenceAndPrint(List<string> sentenceList)
        {
            bool moreWords;
            do
            {
                string word = GetWord();
                sentenceList.Add(word);
                moreWords = AddAnotherWord();
            } while (moreWords);
            string[] sentence = sentenceList.ToArray();

            PrintSentence(sentence);
        }

        static public string GetWord()
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            return input;
        }

        static public bool AddAnotherWord()
        {
            bool doAgain;

            Console.Write("\nWould you like to add another word? Type y for yes or any other key for no. ");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")
            {
                doAgain = true;
            }
            else { doAgain = false; }
            return doAgain;
        }

        static public void PrintSentence(string[] sentenceToPrint)
        {
            foreach (var item in sentenceToPrint)
            {
                Console.Write($"{item} ");
            }
        }

        static public bool DoAnotherSentence()
        {
            bool doAgain;
            Console.WriteLine("\nWould you like to continue? Type y for yes or any other key for no. ");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                doAgain = true;
            }
            else { doAgain = false; }
            return doAgain;
        }
    }
}
