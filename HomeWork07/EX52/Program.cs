// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
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

void MeanColumnValues(int[,] array)
{
    double[] sumVal = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumVal[j] += array[i, j];
        }
        double result = sumVal[j] / array.GetLength(0);
        Console.Write(Math.Round(result,1) + "\t");
    }
}

Console.Write("Введите количество строк и столбцов через пробел: ");
string[] inputArrayRange = Console.ReadLine().Split(' ');
int row = int.Parse(inputArrayRange[0]);
int col = int.Parse(inputArrayRange[1]);

int[,] initArray = GetArray(row, col);
PrintArray(initArray);
MeanColumnValues(initArray);



