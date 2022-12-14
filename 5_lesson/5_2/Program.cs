// Задача 32: Напишите программу замена элементов 
//            массива: положительные элементы замените на
//            соответствующие отрицательные, и наоборот.
//            [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int[] ChangePosNeg(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
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

int[] arr = CreateArray(10, -20, 20);
PrintArray(arr);
Console.WriteLine();
int[] posNegElem = ChangePosNeg(arr);
PrintArray(posNegElem);