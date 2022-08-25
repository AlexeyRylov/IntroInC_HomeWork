/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/

int Ackerman(int m, int n)
{
    if      (m == 0)          { return (n + 1);}
    else if (n == 0 && m > 0) { return Ackerman(m-1, 1); }
    else if (n > 0 && m > 0)  { return Ackerman(m-1, Ackerman(m, n-1)); }
    else                      { return 0;}
}


Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

int result = Ackerman(m, n);
Console.WriteLine(result);