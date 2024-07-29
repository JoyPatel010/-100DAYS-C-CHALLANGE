using System;

namespace day_7_Q1
{
    internal class day_7_Q1
    {
        public static bool IsPrime(int n)
        {
           if(n <= 1)
           {
                return false;
           }

           if(n == 2)
           {
                return true;
           }

           if(n%2 == 0)
           {
                return false;
           }

           for(int i = 3;i<Math.Sqrt(n);i++)
           {
                if(n%i == 0)
                {
                    return false;
                }
           }

           return true;

        }

        public static int sumOfPrimeNumber(int start, int end)
        {
            int sum = 0;

            for(int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    sum = sum + i;
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a starting range to calculate the sum of prime number : ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a ending range to calculate the sum of prime number : ");
            int end = Convert.ToInt32(Console.ReadLine());

            int sumOfPrime = sumOfPrimeNumber(start, end);
            Console.Write("Sum os all Prime number from your range : " + sumOfPrime);

            Console.ReadLine();
        }
    }
}
