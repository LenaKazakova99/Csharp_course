// Задача 49: Задайте двумерный массив. Найдите элементы, у
//            которых оба индекса чётные, и замените эти элементы на их
//            квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 49 2
// 5 81 2 9
// 64 4 4 4

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
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

void EvenIndex (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1)
            {
                if (i % 2 == 0 && j % 2 == 0) matr[i,j] *= matr[i,j];
            }
        }
    }
}

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
EvenIndex(matrix);
PrintMatrix(matrix);