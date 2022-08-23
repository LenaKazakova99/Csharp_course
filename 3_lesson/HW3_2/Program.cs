// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
//            находит расстояние между ними в 3D пространстве.
//            A (3,6,8); B (2,1,-7), -> 15.84
//            A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки 1: ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2: ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
}

double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками A ({x1}, {y1}, {z1}) и B ({x2}, {y2}, {z2}) в 3D пространстве = {Math.Round(result,2)}");