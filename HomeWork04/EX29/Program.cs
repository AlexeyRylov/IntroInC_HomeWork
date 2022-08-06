/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
*/

Console.Write("Введите нижний предел диапазона случайных чисел: ");
int low = int.Parse(Console.ReadLine());
Console.Write("Введите верхний предел диапазона случайных чисел: ");
int high = int.Parse(Console.ReadLine());

int[] Array = new int[8];
Random rnd = new Random();

Console.Write("[ ");
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = rnd.Next(low, high);
    Console.Write(Array[i] + " ");
}
Console.Write("]");



