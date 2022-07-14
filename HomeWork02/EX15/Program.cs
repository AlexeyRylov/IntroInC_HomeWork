/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 | number > 7)
{
    Console.WriteLine("Увы, дня с таким номером не существует!");
} else if (number == 6 | number == 7)
{
    Console.WriteLine("да");
} else{
    Console.WriteLine("нет");
}