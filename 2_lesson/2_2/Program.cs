// 11. Напишите программу, которая выводит случайное трехзначное число и удаляет
//     вторую цифру этого числа.
//     456 -> 46
//     782 -> 72
//     918 -> 98

int number = new Random().Next(100, 1000);

int deleteMiddleDigit(int num)
{
    int second = number / 100;
    int first = number % 10;
    int result = second * 10 + first;
    return result;
}

int res = deleteMiddleDigit(number);
Console.WriteLine($"Сгенерированное число {number}. Обработанное число -> {res}");