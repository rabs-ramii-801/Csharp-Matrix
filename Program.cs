using System;

namespace MatrixPrograms
{
    class MatrixSolver
    {
        // 1. Function to print the elements of the matrix
        public void matrixPrint(int[,] mat)
        {
            Console.WriteLine("---Your Matrix is---");
            int row = mat.GetLength(0);
            int col = mat.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // 2. Function to check whether the inputted matrix is a diagonal matrix or not
        public void diagonalMatrix(int[,] mat)
        {
            int row = mat.GetLength(0);
            int col = mat.GetLength(1);
            bool flag = false;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if ((i != j && mat[i, j] != 0) || (i == j && mat[i, j] == 0))
                    {
                        flag = true;
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("The given Matrix is not a diagonal matrix");
            }
            else
            {
                Console.WriteLine("The given matrix is a diagonal matrix");
            }
        }

        // 3. Function to check whether the given matrix is identity matrix or not
        public void identityMatrix(int[,] mat)
        {
            int row = mat.GetLength(0);
            int col = mat.GetLength(1);
            bool flag = true;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if ((i == j && mat[i, j] != 1) || (i != j && mat[i, j] != 0))
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("The given Matrix is an identity matrix");
            }
            else
            {
                Console.WriteLine("The given matrix is not an identity matrix");
            }
        }

        // 4. Function to find the transpose of the given matrix
        public void matrixTranspose(int[,] mat)
        {
            int row = mat.GetLength(0);
            int col = mat.GetLength(1);
            int[,] transposed = new int[col, row]; // Create a new matrix for the transpose

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    transposed[j, i] = mat[i, j]; // Fill the transposed matrix
                }
            }
            matrixPrint(transposed);
        }

        // 5. Lower and Upper matrix sum calculator function
        public void lowerAndUpperMatrixsum(int[,] mat)
        {
            int row = mat.GetLength(0);

            int lower_sum = 0;
            int upper_sum = 0;

            // Calculating the sum of lower matrix
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    lower_sum += mat[i, j];
                }
            }

            // Calculating the upper matrix
            for (int i = 0; i < row; i++)
            {
                for (int j = row - 1; j >= i; j--)
                {
                    upper_sum += mat[i, j];
                }
            }
            Console.WriteLine("Sum of upper matrix is: " + upper_sum);
            Console.WriteLine("Sum of lower matrix is: " + lower_sum);
        }

        // 6. Function to print the spiral traversal of the given matrix
        public void spiralTraversal(int[,] mat)
        {
            Console.WriteLine("---Spiral Matrix Traversal is---");
            int row = mat.GetLength(0);
            int col = mat.GetLength(1);

            int top = 0;
            int left = 0;
            int right = col - 1;
            int bottom = row - 1;

            while (left <= right && top <= bottom)
            {
                for (int i = left; i <= right; i++)
                {
                    Console.Write(mat[top, i] + " -> ");
                }
                top++;
                for (int i = top; i <= bottom; i++)
                {
                    Console.Write(mat[i, right] + " -> ");
                }
                right--;
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        Console.Write(mat[bottom, i] + " -> ");
                    }
                    bottom--;
                }
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        Console.Write(mat[i, left] + " -> ");
                    }
                    left++;
                }
            }
        }

        // 7. Function to add two matrices
        public int[,] matrixAddition(int[,] mat1, int[,] mat2)
        {
            int row = mat1.GetLength(0);
            int col = mat1.GetLength(1);
            int[,] result = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = mat1[i, j] + mat2[i, j];
                }
            }
            return result;
        }

        // 8. Function to subtract two matrices
        public int[,] matrixSubtraction(int[,] mat1, int[,] mat2)
        {
            int row = mat1.GetLength(0);
            int col = mat1.GetLength(1);
            int[,] result = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = mat1[i, j] - mat2[i, j];
                }
            }
            return result;
        }

        // 9. Function to multiply two matrices
        public int[,] matrixMultiplication(int[,] mat1, int[,] mat2)
        {
            int row1 = mat1.GetLength(0);
            int col1 = mat1.GetLength(1);
            int row2 = mat2.GetLength(0);
            int col2 = mat2.GetLength(1);
            if (col1 != row2)
            {
                throw new ArgumentException("Number of columns in first matrix must be equal to number of rows in second matrix.");
            }

            int[,] result = new int[row1, col2];

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    for (int k = 0; k < col1; k++)
                    {
                        result[i, j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }
            return result;
        }
    }

    class MatrixProblems
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Square Matrix Problem Solver---\n");
            Console.WriteLine("Note: A square matrix is a matrix whose number of rows and columns are equal");

            Console.WriteLine("Please Enter the number of rows and columns of the matrix: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[row, column];
            int[,] matrix2 = new int[row, column];

            Console.WriteLine("Please Enter " + row * column + " elements for the first matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Please Enter " + row * column + " elements for the second matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            MatrixSolver obj = new MatrixSolver();
            obj.matrixPrint(matrix1);
            obj.matrixPrint(matrix2);
            obj.diagonalMatrix(matrix1);
            obj.identityMatrix(matrix1);
            Console.WriteLine("---Transpose of the first matrix is---");
            obj.matrixTranspose(matrix1);
            obj.lowerAndUpperMatrixsum(matrix1);
            obj.spiralTraversal(matrix1);

            // Matrix Addition
            Console.WriteLine("---Matrix Addition Result---");
            int[,] additionResult = obj.matrixAddition(matrix1, matrix2);
            obj.matrixPrint(additionResult);

            // Matrix Subtraction
            Console.WriteLine("---Matrix Subtraction Result---");
            int[,] subtractionResult = obj.matrixSubtraction(matrix1, matrix2);
            obj.matrixPrint(subtractionResult);

            // Matrix Multiplication
            Console.WriteLine("---Matrix Multiplication Result---");
            int[,] multiplicationResult = obj.matrixMultiplication(matrix1, matrix2);
            obj.matrixPrint(multiplicationResult);
        }
    }
}
