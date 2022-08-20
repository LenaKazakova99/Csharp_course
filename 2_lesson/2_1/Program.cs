// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
//    и показывает наибольшую цифру числа.
//    78 -> 8
//    12 -> 2
//    85 -> 5

int number = new Random().Next(10, 100); // 10, 99 + 1
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit == secondDigit) Console.WriteLine("Числа равны");
// else
// {
//     // int max = 0;
//     // if (secondDigit > max) max = secondDigit;
//     // int max = firstDigit > secondDigit ? firstDigit : secondDigit;

//     Console.WriteLine($"Наибольшая цифра числа {number} => ");
//     Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);
//     // Console.WriteLine($"Наибольшая цифра числа {number} => {max}");
// }

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
string result = maxDigit != -1 ? maxDigit.ToString() : "Цифры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {number} => {result}");
