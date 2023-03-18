// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} = {SumNumbers(number)}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; num > 0; i++)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}