// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int quantityNumber  = QuantityNumber(number);
Console.WriteLine($"Кол-во цифр  в числе {number} = {QuantityNumber(number)}");

int QuantityNumber(int num)
{
    int count = 0;
     while  ( num != 0)
     {
        count++;
        num /= 10;
     }
     return count;
}