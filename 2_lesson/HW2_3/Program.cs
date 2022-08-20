// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//            и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void Weekend(int num)
{
    string text = "Не выходной";

    if (num == 7 || num == 6) text = "Выходной";
    Console.WriteLine($"{num} -> {text}");
}

Weekend(num);