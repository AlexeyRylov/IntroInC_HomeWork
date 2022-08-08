/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Write("Введите размерность массива: ");
int range = int.Parse(Console.ReadLine());
int[] array = new int[range];

Random rand = new Random();
int result = 0;

for (int i = 0; i < range; i++)
{
    array[i] = rand.Next(100, 1000);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0)
    {
        result += 1;
    }
}

Console.WriteLine();
Console.Write("Количество четных чисел в массиве равно " + result);