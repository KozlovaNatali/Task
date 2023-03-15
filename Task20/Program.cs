// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double d = Math.Sqrt(5);
// double res = 5.099987564;
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(resRound);

Console.WriteLine("Введите координату X первой точки : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки : ");
int y2 = Convert.ToInt32(Console.ReadLine());
double resRound = Math.Round(Distance(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между координатами равно {resRound}");
 
double Distance(int aX, int aY,int bX,int bY)
{
   return Math.Sqrt((aX - bX) * ( aX - bX) + (aY - bY) * (aY - bY));
}