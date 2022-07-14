/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное целое число: ");
int number = int.Parse(Console.ReadLine());

if (((number / 100) < 1) | ((number / 1000) >= 1))
{
    Console.WriteLine("Число не трехзначное!");
}
else
{
    int result = Cut(number);
    Console.WriteLine("Вторая цифра: " + result);
}

int Cut(int a)
{
    int b = a / 10;
    int c = b % 10;
    return c;
}