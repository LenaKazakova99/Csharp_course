// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число в квадрате: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == num1*num1)
{
    Console.WriteLine($"Число {num2} является квадратом числа {num1}");
}
else
{
    Console.WriteLine($"Число {num2} не является квадратом числа {num1}");
}
