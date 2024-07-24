using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_Q1
{
    internal class day_5_Q1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to calculate sum of the digit : ");
            int a = Convert.ToInt32(Console.ReadLine());

            
            int sum = 0;
                
            while(a>0)
            {
                int modul = a % 10;
                sum += modul;
                a = a / 10;
                
            }

            Console.Write(sum);    

            Console.ReadLine();

        }
    }
}
