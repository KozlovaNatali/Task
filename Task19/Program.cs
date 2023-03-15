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

    bool Palindrome(int num1)
    {
        int ReversePalindrome = 0;
        int t = 0;
        int num = num1;
        while (num > 0)
        {
            t = num % 10;
            ReversePalindrome = ReversePalindrome * 10 + t;
            num = num / 10;
        }
        return num1 == ReversePalindrome;
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}