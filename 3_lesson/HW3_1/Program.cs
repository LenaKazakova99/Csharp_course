// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//            является ли оно палиндромом.
//            14212 -> нет
//            12821 -> да
//            23432 -> да

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void Palindrome(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "является палиндромом";
    
    while (i < size / 2)
    {
        if (num[i] != num[size - i]) 
        {
            flag = "не является палиндромом";
            break;
        }        
        i += 1;
    }    
    Console.WriteLine($"Число {n} -> {flag}");
}

Palindrome(n);