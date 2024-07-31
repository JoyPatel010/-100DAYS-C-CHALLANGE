using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_8
{
    internal class day_8_Q
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers to find the median : ");
            string num = Console.ReadLine();

            int[] numbers = num.Split(' ').Select(int.Parse).ToArray();

            double median = FindMedian(numbers);
            Console.Write($"Median: {median}");

            Console.ReadLine();

        }

        public static double FindMedian(int[] array)
        {
            if(array.Length == 0)
            {
                throw new InvalidOperationException("Can not find median of empty array.");
            }


            Array.Sort(array);

            
            if(array.Length == 1)
            {
                return array[0];
            }

            if(array.Length%2 == 1)
            {
                return array[array.Length/2];
            }
            else
            {
                int med1 = array[array.Length / 2 - 1];
                int med2 = array[array.Length / 2];
                return (med1+med2) / 2.0; 
            }
        }

        
    }
}
