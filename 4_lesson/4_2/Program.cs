// Задача 26. Напишите программу, которая принимает на вход число и выдает количество
//            цифр в числе.
//            456 -> 3
//            78 -> 2
//            89126 -> 5

Console.WriteLine("Введите целое число: ");
int A = Convert.ToInt32(Console.ReadLine());

int CountNumbers(int num)
{
    int counter = 1;
    while (A >= 10)
    {
        A = A / 10;
        counter++;
    }
    return counter;
}
int result = CountNumbers(A);

Console.WriteLine($"Количество цифр в числе -> {result}");

// int counter = 1;
// for (int i = 1; A >= 10; A = A / 10)
// {
//     counter++;
// }

// Console.WriteLine($"Количество цифр в числе -> {counter}");