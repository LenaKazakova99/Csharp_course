// 22. Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов
//     чисел от 1 до N.
//     5 -> 1, 4, 9, 16, 25
//     2 -> 1, 4

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void Kvadrat(int N)
{
    int count = 1;
    while (count <= N)
    {
        Console.WriteLine($"{count }, {count * count}");
        count++;
    }
}

Kvadrat(N);