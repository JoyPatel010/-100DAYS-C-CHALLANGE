using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_Q4
{
    internal class day_6_Q4
    {

        public static void checkPalindromicNum(int limit)
        {
            for(int i = 0; i <= limit; i++)
            {
                string numStr = i.ToString();

                string reverseStr = ReverseStr(numStr);

                if(numStr == reverseStr)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static string ReverseStr(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);  
        }
        static void Main(string[] args)
        {
            int limit = 1000;
            checkPalindromicNum(limit);

            Console.ReadLine();
        }
    }
}
