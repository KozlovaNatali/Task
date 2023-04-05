// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Вводим число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводим число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

if(numberM < 0 || numberN < 0)
{
    Console.WriteLine("Введены не натуральные числа");
}
else
{
    int sum = SumElements(numberM, numberN);
    Console.WriteLine($"Сумма элементов от {numberM} до {numberN} равна {sum}");
}

int SumElements(int M, int N)
{
    int sum = 0;
    if (M == N) return N;
    if(N < M)
    {
       sum += N + SumElements( M, N + 1);
    }
    else
    {
        sum += M + SumElements( M + 1, N);
    }
    return sum;
}    
