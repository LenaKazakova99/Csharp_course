// 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
//     является ли второе число кратным первому. Если число 2 не кратно числу 1, то 
//     программа выводит остаток от деления. 
//     34, 5 -> не кратно, остаток 4
//     16, 4 -> кратно

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine ($"Число {num1} кратно числу {num2}");
}
else
{
    Console.WriteLine($"Число {num1} не кратно числу {num2}. Остаток {num1 % num2}");
}