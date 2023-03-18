// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number2 < 0)
{
    Console.WriteLine($"Число B не является натуральным");
}
else
{
Math.Pow(number1,number2);
Console.WriteLine("number1^number2 = " + Math.Pow(number1, number2));
}