// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();

Console.WriteLine(SumOfElementsInARow(array2d) + 1);

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

int SumOfElementsInARow(int[,] matrix)
{
    int [] sumElementsRow = new int[matrix.GetLength(0)];
    
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumElementsRow[i] = sum;
     }
    return FindMinNumberFromArray(sumElementsRow);
}
int FindMinNumberFromArray(int [] arr)
{
    int min = arr[0];
    int num = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
            num = i;
        }
    }
    return num;
}

