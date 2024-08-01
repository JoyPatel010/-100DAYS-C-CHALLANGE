using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9_InterviewQue
{
    internal class day_9_InterviewQue
    {
        static void Main(string[] args)
        {
            Console.Write("How many times do you want to print the pattern of star : ");
            int n = Convert.ToInt32(Console.ReadLine());

            do
            {

                int i;
                for (i = 0; i < 3; i++)
                {
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write(' ');
                    }


                    for (int j = 0; j >= 0; j--)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();



                }
                if (i == 3)
                {
                    for (int g = 1; g < i; g++)
                    {
                        for (int h = g; h <= 2; h++)

                        {
                            Console.Write(' ');
                        }

                        for (int l = 0; l <= 0; l++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }


                }

                n--;
            } while (n > 0);


            Console.ReadLine();
        }
    }
}
