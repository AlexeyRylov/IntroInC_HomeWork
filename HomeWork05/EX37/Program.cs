/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
Console.WriteLine();

for (int i = 0; i < (size / 2); i++)
{
    Console.Write(newArray[i] * newArray[size - i - 1] + " ");
}
