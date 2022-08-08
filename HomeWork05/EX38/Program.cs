/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Введите нижнюю границу диапазона чисел: ");
int low = int.Parse(Console.ReadLine());

Console.Write("Введите верхнюю границу диапазона чисел: ");
int high = int.Parse(Console.ReadLine());

int[] newArray = new int[size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
    newArray[i] = rnd.Next(low, high + 1);
    Console.Write(newArray[i] + " ");
}

int max = newArray[0];
int min = newArray[0];

for (int i = 0; i < size; i++)
{
    if (newArray[i] > max)
    {
        max = newArray[i];
    }
    if (newArray[i] < min)
    {
        min = newArray[i];
    }
}
Console.WriteLine();
Console.WriteLine(max);
Console.WriteLine(min);
Console.Write("Разница между максимальным и минимальным элементами массива равна: " + (max - min));