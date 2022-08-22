// 20. Напишите программу, которая принимает на вход координаты двух точек и находит 
//     расстояние между ними в 2D пространстве.
//     A (3,6); B (2,1) -> 5,09
//     A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки 1: ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2: ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

double result = Distance(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками A ({x1}, {y1}) и B ({x2}, {y2}) = {Math.Round(result,2)}");