// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = CreateMatrixRndInt(4, 2, 1, 5);
PrintMatrix(array1);
Console.WriteLine();
int[,] array2 = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(array2);
Console.WriteLine();
if(array1.GetLength(0) == array2.GetLength(1))
{
int[,] array3 = ProductOfTwoMatrices(array1, array2);
PrintMatrix(array3);
}
else
Console.WriteLine("Число  строк матрицы array1 не равняется числу столбцов матрицы array2. Умножение невозможно!");
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}

int[,] ProductOfTwoMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}
