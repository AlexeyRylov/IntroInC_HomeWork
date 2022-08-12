/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Пример:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

float[] ParseStringArrays(string[] initArray)     //метод для преобразования массива со string элементами в массив с float элементами
{
    float[] tmpArray = new float[initArray.Length];
    for (int i = 0; i < initArray.Length; i++)
    {
        tmpArray[i] = float.Parse(initArray[i]);
    }
    return tmpArray;
}

Console.WriteLine("Введите коэффициенты k1 и b1 первой прямой, разделите их пробелом: ");
string first = Console.ReadLine();
string[] firstStringArray = first.Split(' ');
float[] firstFloatArray = ParseStringArrays(firstStringArray);

Console.WriteLine("Введите коэффициенты k2 и b2 второй прямой, разделите их пробелом: ");
string second = Console.ReadLine();
string[] secondStringArray = second.Split(' ');
float[] secondFloatArray = ParseStringArrays(secondStringArray);

//Нахождение Х координаты точки пересечения:
float x = (secondFloatArray[1] - firstFloatArray[1]) / (firstFloatArray[0] - secondFloatArray[0]);

//Нахождение Y координаты точки пересечения:
float y = secondFloatArray[0] * x + secondFloatArray[1];
Console.WriteLine("Точка пересечения: [" + x + ", " + y + "]");



