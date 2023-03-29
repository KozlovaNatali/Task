// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
if (k1 - k2 == 0 && b2 - b1 !=0)
{
    Console.WriteLine("Эти прямые параллельны");
}
else if (b2 - b1 == 0)
{
    Console.WriteLine("Эти прямые совместны");
}
else
{
    double x = FindX();
    double y = FindY(x);
    Console.WriteLine(x);
    Console.WriteLine(y);
}
double FindX()
{
    double b = b2 - b1;
    double k = k1 - k2;
    return b / k;
}
double FindY(double x)
{
    return k2 * x + b2;
}


