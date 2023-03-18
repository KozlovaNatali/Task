// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.WriteLine("Введите минимальный диапазон массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(num1, num2);
int [] array = new int [8];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(num1, num2);
    Console.Write(array[i] + " ");
}
Console.WriteLine("->[{0}]", string.Join(", ", array));