using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_7_Q2
{
    internal class day_7_Q2
    {

        public static List<int> generateFibonacciSeries(int N)
        {
            List<int> fibonacciSeries = new List<int>();

            if (N >= 1)  fibonacciSeries.Add(0);

            if(N >= 2) fibonacciSeries.Add(1);

            for(int i = 2; i < N; i++)
            {
                int nextFibonacciNum = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
                fibonacciSeries.Add(nextFibonacciNum);
            }

            return fibonacciSeries;


        }


        static void Main(string[] args)
        {
            Console.Write("Enter a Number to Generate Fibonacci series : ");
            int N = Convert.ToInt32(Console.ReadLine());

            List<int> generateFibonacci = generateFibonacciSeries(N);


            bool first = true;
            foreach(int i in generateFibonacci)
            {
                if (!first)
                {
                    Console.Write(",");
                }
                Console.Write(i);
                first = false;
            }

           

            Console.ReadLine();
        }
    }
}
