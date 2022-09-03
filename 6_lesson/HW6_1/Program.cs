// Задача 41: Пользователь вводит с клавиатуры M чисел.
//            Посчитайте, сколько чисел больше 0 ввёл пользователь.
//            0, 7, 8, -2, -2 -> 2
//            -1, -7, 567, 89, 223-> 3

int CountNum(int num)
{
    int count = 0;

    for (int i = 0; i <= num; i++)
    {
        Console.WriteLine($"Число {i}: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел хотели бы ввести?: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0, из которых ввёл пользователь -> {CountNum(num1)}");
