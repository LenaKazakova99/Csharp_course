// Задача 38: Задайте массив вещественных чисел.
//            Найдите разницу между максимальным и минимальным
//            элементами массива.
//            [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arr1 = CreateArray(5);
PrintArray(arr1);
MaxMin(arr1);

double[] CreateArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (5 + 20) - 5, 2);
    }
    return array;
}

void PrintArray(double[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

void MaxMin(double[] array)
{
    double max = 0;
    double min = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
        else if (min > array[i])
            min = array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Max: {max}, min: {min}. ");
    Console.WriteLine($"Разница: {max} - ({min}) = {Math.Round(max - min, 2)}");
}
