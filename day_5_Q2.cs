using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_Q2
{
    internal class day_5_Q2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to fine, it is a perfect number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;


            for(int i = 1; i < a - 1; i++)
            {
                if(a%i == 0)
                {
                    sum = sum + i;
                }

            }
            if (sum == a)
            {
                Console.WriteLine("It is a perfect Number");

            }
            else
            {
                Console.WriteLine("It is not a perfect Number");

            }

        }
    }
}
