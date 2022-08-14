// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void SearchElement(int[,] array, int posRow, int posCol)
{
    if (array.GetLength(0) < posRow || array.GetLength(1) < posCol)
    {
        Console.Write("Увы, элемента с такими координатами в масииве нет");
    }
    else
    {
        Console.Write("В указанной ячейке расположено значение " + array[posRow, posCol]);

    }
}

Console.Write("Введите количество строк и столбцов через пробел: ");
string[] inputArrayRange = Console.ReadLine().Split(' ');
int row = int.Parse(inputArrayRange[0]);
int col = int.Parse(inputArrayRange[1]);

Console.Write("Введите координаты элемента в массиве через пробел: ");
string[] inputPosition = Console.ReadLine().Split(' ');
int posRow = int.Parse(inputPosition[0]);
int posCol = int.Parse(inputPosition[1]);

int[,] initArray = GetArray(row, col);
PrintArray(initArray);
SearchElement(initArray, posRow, posCol);

