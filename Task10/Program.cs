// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int SecondNum (int num) 
{
     num = num / 10;
     num = num % 10;
     return num;
}

Console.Write("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if(Number < 0 )
{
    Number = -Number;
}
if(Number > 99 && Number < 1000)
    {
      Console.WriteLine($"Вторая цифра этого числа {SecondNum(Number)}");  
    }
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}

