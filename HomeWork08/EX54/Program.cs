/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

int[,] SortBubble(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int tmp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = tmp;
                }
            }
        }
    }
    return array;
}

 
int[,] initArray = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

PrintArray(SortBubble(initArray));

