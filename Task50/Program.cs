// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

Console.WriteLine("Введите индекс строки: ");
int index1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца: ");
int index2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
if (ElementValue(array2d, index1, index2))
{
    int searchNumber = array2d[index1, index2];
    Console.WriteLine($"Значение заданного элемента {searchNumber}");
}
else
    Console.WriteLine("Такого числа в массиве нет");


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

bool ElementValue(int[,] matrix, int i1, int i2)
{
    if (matrix.GetLength(0) < i1 + 1  || matrix.GetLength(1) < i2 + 1 || i1 < 0 || i2 < 0)
    {
        return false;
    }
    return true;
}


