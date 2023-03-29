// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите кол-во элементов массива: ");
int CountElements = Convert.ToInt32(Console.ReadLine());

int[] CustomArray = new int[CountElements];
for (int i = 0; i < CustomArray.Length; i++)
{
    Console.Write("Введите число : ");
    CustomArray[i] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] CustomArray)
{
    Console.Write("[");
    for (int i = 0; i < CustomArray.Length; i++)
    {
        if (i < CustomArray.Length - 1) Console.Write($"{CustomArray[i]}, ");
        else Console.Write($"{CustomArray[i]}");
    }
    Console.Write("]");
}
int CountPozitiveElements(int[] CustomArray)
{
    int count = 0;
    for (int i = 0; i < CustomArray.Length; i++)
    {
        if (CustomArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

PrintArray(CustomArray);
Console.WriteLine();

int result = CountPozitiveElements(CustomArray);
Console.WriteLine(result);
