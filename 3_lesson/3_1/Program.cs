// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причем
//     X и Y не равны 0 и выдает номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("I четверть");
// else if (x < 0 && y > 0) Console.WriteLine("II четверть");
// else if (x < 0 && y < 0) Console.WriteLine("III четверть");
// else if (x > 0 && y < 0) Console.WriteLine("IV четверть");
// else Console.WriteLine("Введены некорректные координаты");


string Quater(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "I четверть";
    if (xc < 0 && yc > 0) return "II четверть";
    if (xc < 0 && yc < 0) return "III четверть";
    if (xc > 0 && yc < 0) return "IV четверть";
    return "Введены некорректные координаты";
}

string result = Quater(x, y);
Console.WriteLine(result);
