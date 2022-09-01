﻿// Задача 36: Задайте одномерный массив, заполненный
//            случайными числами. Найдите сумму элементов, стоящих
//            на нечётных позициях
//            [3, 7, 23, 12] -> 19
//            [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int calcArr(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] arr1 = CreateArray(12, 0, 10);
PrintArray(arr1);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях -> " + calcArr(arr1));