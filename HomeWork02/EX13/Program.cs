/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if ((number / 100) < 1)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int result = Cut(number);
    Console.WriteLine("третья цифра: " + result);
}

int Cut(int a)
{
    int n = 0;
    int b = a;
    //определяем разряд числа
    while (b > 0)
    {
        b = b / 10;
        n++;
    }
    //отбрасываем разряды пока не останется 3
    while (n > 3)
    {
        a = a / 10;
        n--;
    }
    int c = a % 10;
    return c;
}