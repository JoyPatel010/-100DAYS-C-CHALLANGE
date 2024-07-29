using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_7_Q4
{
    internal class day_7_Q4
    {

        public static string checkLongestWord(string firstText)
        {
            string[] words = firstText.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = string.Empty;

            foreach(string word in words)
            {
                if(word.Length > longestWord.Length) longestWord = word;
            }

            return longestWord;
        }
        static void Main(string[] args)
        {
            string firstText = "India won T20 world Cup";

            string longesteWord = checkLongestWord(firstText);

            Console.WriteLine("Longest Word is : " +  longesteWord);

            Console.ReadLine(); 
        }
    }
}
