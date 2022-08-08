/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
*/

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Введите нижнюю границу диапазона чисел: ");
int low = int.Parse(Console.ReadLine());

Console.Write("Введите верхнюю границу диапазона чисел: ");
int high = int.Parse(Console.ReadLine());

int[] newArray = new int[size];
Random rnd = new Random();
int result = 0;

for (int i = 0; i < size; i++)
{
    newArray[i] = rnd.Next(low, high + 1);
    Console.Write(newArray[i] + " ");
    if (i % 2 != 0)
    {
        result += newArray[i];
    }
}

Console.WriteLine();
Console.WriteLine("Сумма элементов нечетных позиций равна: " + result);