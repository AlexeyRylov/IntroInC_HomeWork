/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/
int CalcPositiveNumbers(string[] funcArray)
{
    int[] tmpArray = new int[funcArray.Length];
    int count = 0;
    for (int i = 0; i < funcArray.Length; i++)
    {
        tmpArray[i] = int.Parse(funcArray[i]);
        if (tmpArray[i] > 0)
        {
            count +=1;
        }
    }
    return count;
}

Console.WriteLine("Введите числа, разделите их пробелом: ");
string initString = Console.ReadLine();
string[] initSplit = initString.Split(' ');

int result = CalcPositiveNumbers(initSplit);
Console.WriteLine("Количество положительных чисел: " + result);



