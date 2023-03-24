﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int[] result = ToFibonacci(number);

PrintArray(result);


int[] ToFibonacci(int num)
{
    int[] number = new int[num];
    number[0] = 0;
    number[1] = 1;

    for (int i = 2; i < num; i++)
    {
        number[i] = number[i - 1] + number[i - 2];

    }
    return number;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}
