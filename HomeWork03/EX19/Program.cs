/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
int numberIn = int.Parse(Console.ReadLine());

if (numberIn > 99999 || numberIn < 10000)
{
    Console.Write("Введенное число не пятизначное");
} else
{
    CheckForPolindrom(numberIn);
}

void CheckForPolindrom(int numberFunc)
{
    if ((numberFunc % 10 == numberFunc / 10000) &&
    ((numberFunc / 10) % 10 == (numberFunc / 1000) % 10))
    {
        Console.Write("да");
    }
    else
    {
        Console.Write("нет");
    }
}