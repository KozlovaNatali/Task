// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      else return n * FactorialRec(n - 1);
//  }

//  Console.WriteLine(FactorialRec(10)); // 3628800

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumDigirs(number);
Console.WriteLine($"Сумма чисел в цифре равна {sum}");

int SumDigirs( int num)
{
    if (num == 0) return 0;
    else return SumDigirs(num / 10) + num % 10;
}