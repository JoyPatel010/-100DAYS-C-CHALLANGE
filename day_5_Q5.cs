using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_Q5
{
    internal class day_5_Q5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number to calculate the power : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Power of number to calculate the power : ");
            int b = Convert.ToInt32(Console.ReadLine());


            int power = 1;

            for(int i = 1; i<= b; i++)
            {
                power = power * a;
            }

            Console.Write("Calculation : " +  power);

            Console.ReadLine();
        }
    }
}
