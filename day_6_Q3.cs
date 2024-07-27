using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_Q3
{
    internal class day_6_Q3
    {
        public static bool isMagicSqr(int[,] matrix)
        {
            int N = matrix.GetLength(0);

            int sumTarget = 0;
            
            //first row sum
            for(int j = 0; j < N; j++)
            {
                sumTarget += matrix[0, j];
            }

            //check sum of all rows
            for(int i = 0; i < N; i++)
            {
                int rowsSum = 0;
                for(int j = 0; j < N; j++)
                {
                    rowsSum += matrix[i, j];
                }

                if(rowsSum == sumTarget)
                    return true;
            }

            //check sum of columns
            for(int j = 0; j < N; j++)
            {
                int sumColumn = 0;
                for (int i = 0; i < N; i++)
                {
                    sumColumn += matrix[i, j];
                }

                if(sumColumn == sumTarget)
                {
                    return true;
                }
            }

            //check sum of the main diagonal
            int mainDiag = 0;
            for(int i = 0; i < N; i++)
            {
                mainDiag += matrix[i, i];
            }
            if(mainDiag == sumTarget)
            {
                return true ;
            }


            //check second diagonal
            int secondDiang = 0;
            for(int i = 0; i<N; i++)
            {
                secondDiang += matrix[i, i];
            }
            if(secondDiang == sumTarget)
            {
                return true ;
            }


            return false;
        }
        static void Main(string[] args)
        {
            //example matrix
            int[,] matrix = {
                { 2, 7, 6 },
                { 9, 5, 1 },
                { 4, 3, 8 }
            };


            if (isMagicSqr(matrix))
            {
                Console.WriteLine("This matrix is magic square");
            }
            else
            {
                Console.WriteLine("This matrix is not magic square");
            }

        }
    }
}
