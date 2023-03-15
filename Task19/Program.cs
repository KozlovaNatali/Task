// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
if (number < 100000 && number > 9999)
{
    bool result = Palindrome(number);
    Console.WriteLine(result ? "Число является палиндромом" : "Число не является палиндромом");
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}

bool Palindrome(int num)
{
    int ReversePalindrome = 0;
    int temp = 0;
    while (num > 0)
    {
        temp = num % 10;
        ReversePalindrome = ReversePalindrome * 10 + temp;
        num = num / 10;
    }
    return number == ReversePalindrome;
}