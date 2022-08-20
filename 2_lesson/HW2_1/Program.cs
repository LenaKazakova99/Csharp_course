// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе
//            показывает вторую цифру этого числа.
//            456 -> 5
//            782 -> 8
//            918 -> 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int TakeNum(int num)
{
    if (num >= 100 && num <= 999) return num;
    int result = num / 10 % 10;
    return result;
}
int result = TakeNum(num);
Console.WriteLine($"Вторая цифра трехзначного числа -> {result}");