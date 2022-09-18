// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

string Number(int[,] matr, int n, int m)
{
    if (n > matr.GetLength(0) || n <= 0 || m > matr.GetLength(1) || m <= 0)
        return "такого элемента нет";
    return $"значение элемента {n} строки и {m} столбца равно {matr[n - 1, m - 1]}";
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(Number(matrix, n, m));