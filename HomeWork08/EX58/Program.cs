/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

int[,] MatrixMul(int[,] A, int[,] B)
{
    int[,] result = new int[A.GetLength(0), B.GetLength(1)];
    if (A.GetLength(0) != B.GetLength(1))
    {
        Console.WriteLine("Матрицы не согласованы");
    }
    else
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                for (int k = 0; k < B.GetLength(0); k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }
    }
    return result;

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = {
    {1,4},
    {2,5},
    {3,6}
    };

int[,] matrixB = {
    {7,8,9,10},
    {10,11,12,10}
    };

int[,] resultArray = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
resultArray = MatrixMul(matrixA, matrixB);
PrintArray(resultArray);