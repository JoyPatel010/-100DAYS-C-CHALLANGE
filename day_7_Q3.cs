using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_7_Q3
{
    internal class day_7_Q3
    {

        public static bool checkPalindromeNum(int n)
        {
            string str1 = n.ToString();

           
            string str2 = reverseString(str1);
           

            if(str1 == str2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string reverseString(string str1)
        {
            char[] storeN = str1.ToCharArray();
            Array.Reverse(storeN);
            return new string(storeN);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it a Palindrome : ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool a  = checkPalindromeNum((int)n);

            if(a == true)
            {
                Console.WriteLine("It is a Palindrom Number");
            }
            else
            {
                Console.WriteLine("It is not a Palindrom Number");
            }

            

            Console.ReadLine();
        }
    }
}
