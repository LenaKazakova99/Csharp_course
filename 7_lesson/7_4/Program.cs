// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void SumMatrix(int[,] matr)
{
    int sum = 0;
    // for (int i = 0; i < matr.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matr.GetLength(1); j++)
    //     {
    //         if (i == j) sum += matr[i, j];
    //     }
    // }
    int size = matr.GetLength(0);
    if (matr.GetLength(0) > matr.GetLength(1)) size = matr.GetLength(1);
    for (int i = 0; i < matr.GetLength(0) && i < matr.GetLength(1); i++)
    {
        int j = i;
        sum += matr[i, j];
    }
    Console.WriteLine(sum);
}

int[,] matrix = CreateMatrixRndInt(6, 6, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
SumMatrix(matrix);
