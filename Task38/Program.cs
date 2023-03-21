// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] arr = new double[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         double num = rnd.NextDouble() * (max - min) + min;
//         arr[i] = Math.Round(num, 1);
//     }
//     return arr;
// }
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(5, 0, 10);
PrintArray(array);
Console.WriteLine();
double max = MaxElements(array);
Console.WriteLine($"Максимальный элемент в массиве равен {max}");
double min = MinElements(array);
Console.WriteLine($"Минимальный элемент в массиве равен {min}");
double DiffBetweenElem = DifferenceBetweenElements(array);
Console.WriteLine($"Разница между ними {DiffBetweenElem}");
double[] CreateArrayRndDouble(int size, int min, int max, int round = 1)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double MaxElements(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinElements(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double DifferenceBetweenElements(double[] array)
{
    double diff = 0;
    diff = max - min;
    diff = Math.Round(diff, 1);
    return diff;
}

