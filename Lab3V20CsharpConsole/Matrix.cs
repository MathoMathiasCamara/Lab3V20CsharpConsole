using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3V20CsharpConsole
{
    public class Matrix
    {
        // initiate a variable for the matrix size
        const int sizeMatrix = 3;

        //element in the matrix
        public int[,] MatrixA;
        public int[,] MatrixB;

       
        //print the matrix content
        public void PrintMatrix(int[,] Amatrix,string name)
        {
            //displaying the matrix content
            Console.WriteLine("Matrix {0}:\n",name);

            for(int i = 0; i < sizeMatrix; i++)
            {
                for(int j = 0; j < sizeMatrix; j++)
                {
                    Console.Write("{0}\t", Amatrix[i,j]);
                }
                Console.WriteLine("\n");
            }
        }

         // caculate the matrix X=2*A(A+B)-3*A
            public int[,] CalculateMatrixX()
            {
            int[,] matrixX = new int[sizeMatrix, sizeMatrix];
                for (int i = 0; i < sizeMatrix; i++)
                {
                    for (int j = 0; j < sizeMatrix; j++)
                    {
                    matrixX[i, j] = (2 * MatrixA[i, j]*(MatrixA[i, j]+ MatrixB[i, j]))-(3* MatrixA[i, j]);
                    }
                    
                }            
            return matrixX;
            }

        public int[,] ReverserMatrix(int[,] matrixX)
        {
            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    matrixX[i, j] = CalculateMatrixX()[j,i];
                }
            }
            return matrixX;
        }

        //Return the value IsSymetric
        public bool IsSymetric(int[,] Matrix,int[,] ReverseMatrix)
        {
            var symetric = 0;
            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    if (Matrix[i, j] == ReverseMatrix[i,j])
                        symetric+=1;
                }
            }
            return symetric == sizeMatrix*sizeMatrix;
        }

        //Constructor
        public Matrix(int[,] matrixA, int[,] matrixB)
        {
            MatrixA = matrixA;
            MatrixB = matrixB;
        }
        //Desctructor
        ~Matrix()
        {
            Console.WriteLine("All Matrixes have been deleted.");
        }

    }
}
