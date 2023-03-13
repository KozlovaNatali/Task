// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdNumber(int num)
{
    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        num = num % 10;
    }
    return num;
}

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number < 0)
{
    Number = -Number;
}
if (Number > 99)
{
    Console.WriteLine($"Третья цифра этого числа {ThirdNumber(Number)}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
