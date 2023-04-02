// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = CreateSpiralArray(4,4);
PrintMatrix(array);
Console.WriteLine();

int[,] CreateSpiralArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int max = rows * columns;
    int i = 0;
    int j = 0;
    int num = 1;
    string direction = "right";

    while (num <= max)
    {
        if (direction == "right")
        {
            matrix[i, j] = num;
            num++;
            if (j + 1 >= matrix.GetLength(1) || matrix[i, j + 1] != 0)
            {
                i++;
                direction = "down";
            }
            else
            {
                j++;
            }
        }
        else if (direction == "down")
        {
            matrix[i, j] = num;
            num++;
            if (i + 1 >= matrix.GetLength(0) || matrix[i + 1, j] != 0)
            {
                j--;
                direction = "left";
            }
            else
            {
                i++;
            }
        }
        else if (direction == "left")
        {
            matrix[i, j] = num;
            num++;
            if (j - 1 < 0 || matrix[i, j - 1] != 0)
            {
                i--;
                direction = "up";
            }
            else
            {
                j--;
            }
        }
        else if (direction == "up")
        {
            matrix[i, j] = num;
            num++;
            if (i - 1 < 0 || matrix[i - 1, j] != 0)
            {
                j++;
                direction = "right";
            }
            else
            {
                i--;
            }
        }
        else
        {
            break;
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
            Console.Write($"{matrix[i, j],0:d2} ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}