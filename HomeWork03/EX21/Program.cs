/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите координату Х первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Х второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

CalcDistance(x1, y1, z1, x2, y2, z2);

void CalcDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double Distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.Write("Расстояние между точками = " + Math.Round(Distance, 2));
}

