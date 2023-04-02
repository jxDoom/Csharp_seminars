// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();

Console.Write("Point A X coordinate: ");
int Xa = int.Parse(Console.ReadLine());
Console.Write("Point A Y coordinate: ");
int Ya = int.Parse(Console.ReadLine());
Console.Write("Point A Z coordinate: ");
int Za = int.Parse(Console.ReadLine());

Console.Write("Point B X coordinate: ");
int Xb = int.Parse(Console.ReadLine());
Console.Write("Point B Y coordinate: ");
int Yb = int.Parse(Console.ReadLine());
Console.Write("Point B Z coordinate: ");
int Zb = int.Parse(Console.ReadLine());

double scalar = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2));
System.Console.WriteLine($"Distance between points in 3D space: {scalar}");
