// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[4] {"Hello", "2", "world", ":-)"};
PrintArray(array);
Console.Write(" -> ");

int count = 0;
NumberOfElements(array);
string[] newArr = NewArray(array, count);
PrintArray(newArr);

void NumberOfElements(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
}

string[] NewArray(string[] arr, int count)
{
    int j = 0;
    string[] newArray = new string[count];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[j] = arr[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
