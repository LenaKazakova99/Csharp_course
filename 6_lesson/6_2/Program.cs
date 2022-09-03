// Задача 40: Напишите программу, которая принимает на вход три
//            числа и проверяет, может ли существовать треугольник с сторонам
//            такой длины.
//            Теорема о неравенстве треугольника: каждая сторона треугольника
//            меньше суммы двух других сторон.

Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());
bool CheckTriangle(int a, int b, int c)
{
    //     if (a1 + b1 > c1 && b1 + c1 > a1 && a1 + c1 > b1)
    //     {
    //         return true;
    //     }
    //     return false;
    return a + b > c && b + c > a && a + c > b;
}
bool result = CheckTriangle(a, b, c);
// if (result) Console.WriteLine("Три числа являются сторонами треугольника");
// else Console.WriteLine("Три числа не являются сторонами треугольника");
Console.Write(result ? "Три числа являются сторонами треугольника" : "Три числа являются сторонами треугольника");
