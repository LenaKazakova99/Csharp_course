// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные
// числа от 1 до N. 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = 2;

while (M < N + 1)
{
    if (M % 2 == 0)
    {
        Console.WriteLine(M);
    }
    M++;
}