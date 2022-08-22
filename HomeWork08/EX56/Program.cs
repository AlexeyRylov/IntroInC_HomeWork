/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int SmallestRow(int[,] array)
{
    int[] summs = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summs[i] += array[i, j];
        }
    }
    int minVal = summs[0];
    int minIndex = 1;
    for (int i = 1; i < summs.Length; i++)
    {
        if (summs[i] < minVal)
        {
            minVal = summs[i];
            minIndex = i + 1;
        };
    }
    return minIndex;
}

int[,] array = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7}
};

Console.Write(SmallestRow(array) + " строка");