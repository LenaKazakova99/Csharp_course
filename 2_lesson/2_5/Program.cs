// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число
//     квадратом другого.
//     5, 25 -> да 
//     -4, 16 -> да 
//     25, 5 -> да 
//     8, 9 -> нет  

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Kvadrat(int num1, int num2)
{
    if (num1 == num2 * num2)
    {
        Console.WriteLine($"Число {num1} является квадратом числа {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
    }
}

Kvadrat(num1, num2);