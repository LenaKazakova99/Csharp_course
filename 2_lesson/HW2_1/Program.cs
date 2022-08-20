﻿// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе
//            показывает вторую цифру этого числа.
//            456 -> 5
//            782 -> 8
//            918 -> 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    Console.WriteLine($"Вторая цифра числа -> {num / 10 % 10}");
}
else
{
    Console.WriteLine("Число не является трехзначным");
}