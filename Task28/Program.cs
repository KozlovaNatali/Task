// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int workNumbers = WorkNumbers(number);
Console.WriteLine($" Произведение чисел от 1 до {number} = {WorkNumbers(number)}");

int WorkNumbers(int num)
{
    int work = 1;
    for (int i = 1; i <= num; i++)
    {
        work *= i; // work = work * i
    }
    return work;
}
