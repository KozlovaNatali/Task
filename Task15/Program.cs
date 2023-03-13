// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да

Console.WriteLine("Введите номер дня недели");
string number = Console.ReadLine();

if(number == "1" || number == "2" || number == "3" || number == "4" || number == "5" )
{
    Console.WriteLine("Будний день");
}
else if(number == "6" || number == "7")
{
    Console.WriteLine("Выходной день");
}
else 
{
     Console.WriteLine("Такого дня недели нет");
}