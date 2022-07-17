/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
*/
double findDistance(double ax, double ay, double az, double bx, double by, double bz)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
}

Console.WriteLine("Введите координаты первой точки ");
double ax = double.Parse(Console.ReadLine());
double ay = double.Parse(Console.ReadLine());
double az = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки ");
double bx = double.Parse(Console.ReadLine());
double by = double.Parse(Console.ReadLine());
double bz = double.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между точками {findDistance(ax, ay, az, bx, by, bz)}");