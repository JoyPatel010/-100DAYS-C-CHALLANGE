using System;

namespace day_5_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pascal's Triangle for 5 Rows

            int[][] triangle = new int[5][];

            // Initialize the size of each row
            for (int i = 0; i < 5; i++)
            {
                triangle[i] = new int[i + 1];
            }

            // Set the first row
            triangle[0][0] = 1;

            // Generate triangle
            for (int i = 1; i < 5; i++)
            {
                triangle[i][0] = 1;  // First element of each row is 1

                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }

                triangle[i][i] = 1;  // Last element of each row is 1
            }

            // Print the triangle
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
