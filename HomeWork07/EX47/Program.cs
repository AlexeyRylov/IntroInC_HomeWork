// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int min, int max, int row, int col)
{
    double[,] array = new double[row, col];
    Random rnd = new Random();
    int sign = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            sign = rnd.Next(0, 2);
            if (sign == 0)
            {
                array[i, j] = Math.Round(rnd.NextDouble() * rnd.Next(min, max), 2);
            }
            else
            {
                array[i, j] = Math.Round(rnd.NextDouble() * rnd.Next(min, max) * -1, 2);
            }

        }
    }
    return array;
}

void PrintArray(double[,] array)
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

Console.Write("Введите диапазон случайных чисел через пробел: ");
string[] inputValuesRange = Console.ReadLine().Split(' ');
int min = int.Parse(inputValuesRange[0]);
int max = int.Parse(inputValuesRange[1]);

Console.Write("Введите количество строк и столбцов через пробел: ");
string[] inputArrayRange = Console.ReadLine().Split(' ');
int row = int.Parse(inputArrayRange[0]);
int col = int.Parse(inputArrayRange[1]);

double[,] initArray = GetArray(min, max, row, col);
PrintArray(initArray);
