using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_Q4
{
    internal class day_5_Q4
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();

            Console.Write("Enter a number to find Prime Factors : ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n%2 == 0)
            {
                primes.Add(2);
                n = n / 2;
            }

            for(int i = 3; i < Math.Sqrt(n); i += 2) {
                while(n % i == 0)
                {
                    primes.Add((int)i);
                    n = n / i;
                }
            }

            if (n > 2)
            {
                primes.Add(n);
            }

            foreach(int i in primes)
            {
                Console.WriteLine(i);
            }
        }
    }
}
