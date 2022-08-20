// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//            что третьей цифры нет. 

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

void ThirdDigit(int num)
{
    if (num < 99)
    {
        Console.WriteLine("Третьей цифры нет");
        return;
    }
    while (num > 999) num = num / 10;
    Console.WriteLine(num % 10);
}
ThirdDigit(num);
