using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 2;
            int col = 2;

            int[][] matrix = new int[row][];

                for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[col];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = i + j;
                }
            }

            foreach (int[] outer in matrix)
            {
                foreach (int inner in outer)
                {
                    Console.Write(inner+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
