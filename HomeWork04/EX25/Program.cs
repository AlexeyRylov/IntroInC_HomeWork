/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

Console.Write("Введите число А: ");
double numA = double.Parse(Console.ReadLine());

Console.Write("Введите число В: ");
double numB = double.Parse(Console.ReadLine());

//double res = Math.Pow(numA, numB);
double res = 1;

for (int i = 1; i <= numB; i++)
{
    res = res * numA;
}

Console.Write("А в степени В равно: " + res);