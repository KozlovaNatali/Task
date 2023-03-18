// int[] array = new int[8]; - заполнен 0
// int[] arr = {1, 2, 3} - задаем определенные значения
// array[3] = 34; - присвоение элементу определенное значение

// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int number = new Random().Next(0, 1);
int [] array = new int [8];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 2);
    Console.Write(array[i] + " " );
}
