/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");               //Организуем ввод
int numberIn = int.Parse(Console.ReadLine());

Cube(numberIn);

void Cube(int numberFunc)
{
    int i = 1;
    if (numberFunc > 1)                         //Расчет при положительном введенном числе
    {
        while (i <= numberFunc)
        {
            Console.Write(i * i * i + " ");
            i++;
        }
    }
    else                                        //Расчет при отрицательном введенном числе
    {
        while (i >= numberFunc)
        {
            Console.Write(i * i * i + " ");
            i--;
        }
    }
}