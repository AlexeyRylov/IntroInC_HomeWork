/*
Напишите программу для вычисления площади круга, прямоугольника и треугольника.
Ввод данных осуществляется в диалоговом режиме. на первом шаге у пользователя
запрашивается фигураЮ площадь которой необходимо вычислить. На втором шаге пользователь
 вводит параметры, необходимые для расчета, затем выводится результат.
*/

Console.Write("Введите название фигуры (круг, прямоугольник, треугольник): ");
string figure = Console.ReadLine();

Calculation(figure);

void Calculation(string figure)
{
    if (figure.ToLower() == "круг")
    {
        Console.Write("Введите радиус: ");
        int radius = int.Parse(Console.ReadLine());
        Console.Write("Площадь круга = " + Math.Round(Math.PI * radius * radius, 3));
    }
    else if (figure.ToLower() == "прямоугольник")
    {
        Console.Write("Введите длину: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Введите ширину: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Площадь прямоугольника = " + length * width);
    }
    else if (figure.ToLower() == "треугольник")
    {
        Console.Write("Введите основание: ");
        int baseSide = int.Parse(Console.ReadLine());
        Console.Write("Введите высоту: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Площадь треугольника = " + 0.5 * baseSide * height);
    } else Console.Write("Ошибка ввода, попробуйте еще раз");

}