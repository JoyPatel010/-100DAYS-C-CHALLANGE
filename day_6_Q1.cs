using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace day_6_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to make multiplication Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            for(int i =1; i<=10; i++)
            {
                int sum;
                sum = a * i;
                Console.WriteLine(a + "*" + i + "=" + sum);
            }
            Console.ReadLine();
        }
    }
}
