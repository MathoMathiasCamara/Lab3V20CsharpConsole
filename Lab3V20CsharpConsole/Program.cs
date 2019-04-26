using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3V20CsharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 3;

            // My custom matrix
            //int[,] A = new int[SIZE, SIZE] { { 2, 3, 4 }, { 1, -2, 0 }, { 0, 1, 2 } };
            //int[,] B = new int[SIZE, SIZE] { { 2, 0, -2 }, { 1, 1, 0 }, { 1, -1, 1 } };

            //fill the table with random data
            Random rdm = new Random();
            int[,] A = new int[SIZE, SIZE];
            int[,] B = new int[SIZE, SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    A[i, j] = rdm.Next(-1, 1);
                    B[i, j] = rdm.Next(-1, 1);
                }
            }

            // Create a matrix instance
            Matrix myMatrix = new Matrix(A,B);

            //Printing the matrix content
            myMatrix.PrintMatrix(myMatrix.MatrixA, "A");
            Console.WriteLine("\n");
            myMatrix.PrintMatrix(myMatrix.MatrixB,"B");

            //Printing the MatrixX after computing :X=2*A*(A+B)-3*A
            Console.WriteLine("\n");
            var matrixX = myMatrix.CalculateMatrixX();
            myMatrix.PrintMatrix(matrixX, "X=2*A*(A+B)-3*A");

            Console.WriteLine("\n");
            // Computing and printing the reverse matrix of matrix X
            var Reversematrix = myMatrix.ReverserMatrix(myMatrix.CalculateMatrixX());
            //Printing
            myMatrix.PrintMatrix(Reversematrix, "Reverse X");

            Console.WriteLine("\n");
            Console.WriteLine("Is Matrix X Symetric ? : {0}",myMatrix.IsSymetric(matrixX, Reversematrix));

            Console.ReadKey();

        }
    }
}
