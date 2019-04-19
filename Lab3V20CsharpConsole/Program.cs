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
            const int size = 3;

            // intializing the matrix
            Matrix myMatrix = new Matrix(new int[size, size] { { 2, 3, 4 }, { 1, -2, 0 }, { 0, 1, 2 } }, new int[size, size] { { 2, 0, -2 }, { 1, 1, 0 }, { 1, -1, 1 } });
            //Matrix myMatrix = new Matrix(new int[size, size] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } }, new int[size, size] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } });

            //Printing the matrix content
            myMatrix.PrintMatrix(myMatrix.MatrixA, "A");
            Console.WriteLine("\n");
            myMatrix.PrintMatrix(myMatrix.MatrixB,"B");

            //Printing the MatrixX
            Console.WriteLine("\n");
            var matrixX = myMatrix.CalculateMatrixX();
            myMatrix.PrintMatrix(matrixX, "X=2*A*(A+B)-3*A");

            Console.WriteLine("\n");
            // Computing and print the reverse matrixe
            var Reversematrix = myMatrix.ReverserMatrix(myMatrix.CalculateMatrixX());
            //Printing
            myMatrix.PrintMatrix(Reversematrix, "Reverse X");

            Console.WriteLine("\n");
            Console.WriteLine("Is Matrix X Symetric ? : {0}",myMatrix.IsSymetric(matrixX, Reversematrix));

            Console.ReadKey();

        }
    }
}
