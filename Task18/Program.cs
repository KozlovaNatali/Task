// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
string numberQuarter = Console.ReadLine();

string result = Range(numberQuarter);
Console.WriteLine(result);

string Range(string x)
{
    if (x == "1") return "x > 0, y > 0";
    if (x == "2") return "x < 0, y > 0";
    if (x == "3") return "x < 0, y < 0";
    if (x == "4") return "x > 0, y < 0";
    return "Введено некоректное значение";
}