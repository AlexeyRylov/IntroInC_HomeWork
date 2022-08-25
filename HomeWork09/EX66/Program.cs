/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNaturalNumbers(int m, int n, int sum)
{
    if (m > n) { return sum; }
    sum += m;
    m++;
    return SumNaturalNumbers(m, n, sum);
}


Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

int sum = 0;
Console.WriteLine(SumNaturalNumbers(m, n, sum));