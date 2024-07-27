using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_Q5
{
    internal class day_6_Q5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to create star pattern : ");
            int n = Convert.ToInt32(Console.ReadLine());

            //print star patterns
            for(int i = 0; i <= n; i++)
            {
                //for loop for spacing
                for(int j = 0;j<= n - i - 1; j++)
                {
                    Console.Write(" ");
                }

                //for print the stars
                for(int k = 0; k <= i * 2; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
