// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол - во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int depth = 2;
int min = 10;
int max = 100;
if(rows * columns * depth < max)
{
int[,,] array3d = CreateMatrixRndInt(rows, columns, depth, min, max);
PrintMatrix(array3d);
Console.WriteLine();
}
else
{
    Console.WriteLine("213");
}

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
               
              matrix[i, j, k] = i * matrix.GetLength(1) * matrix.GetLength(2) + j * matrix.GetLength(2) + k + min;

            }
        }
    }
    return matrix;
}
void PrintMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],6}({i},{j},{k})");
            }
        }
        Console.Write("|");
        Console.WriteLine();
    }
}