// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Вводим число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводим число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
if(numberM < 0 || numberN < 0)
{
    Console.WriteLine("Введены отрицательные числа");
}
else
{
int ackermanFunction = AckermanFunction(numberM, numberN);
Console.WriteLine($"A(m, n) = {ackermanFunction}");
}

int AckermanFunction(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = AckermanFunction(n, m - 1);
        n -= 1;
    }
    return m + 1;
}