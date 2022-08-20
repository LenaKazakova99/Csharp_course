// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
//     одновременно 7 и 23.
//     14 -> нет 
//     46 -> нет 
//     161 -> да 

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool CheckNum(int num)
{
   return num % 7 == 0 && num % 23 == 0;
}

bool result = CheckNum(num);

Console.WriteLine(result ? "Да" : "Нет");