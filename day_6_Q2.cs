using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_Q2
{
    internal class day_6_Q2
    {
        public static void generateMatrix(int N)
        {
            int[,] matrix = new int[N, N];
            int top = 0, bottom = N - 1, left = 0, right = N - 1;
            int num = 1;

            while(num <= N*N)
            {
                //fill from left to right
                for(int i = left;i<= right; i++)
                {
                    matrix[top, i] = num++;

                }
                top++;

                //fill from top to bottom
                for (int i = top;i<= bottom; i++)
                {
                    matrix[i,right]=num++;
                    
                }
                right--;

                //fill from right to left
                for(int i=right;i>=left;i--)
                {
                    matrix[bottom,i] = num++; 
                    
                }
                bottom--;

                //fill from bottom to top
                for (int i = bottom; i >= top; i--)  
                {
                    matrix[i, left] = num++;
                }
                left++;


            }

            //print matrix
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");

                }

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int N = 4;
            generateMatrix(N);

            Console.ReadLine();
        }
    }
}
