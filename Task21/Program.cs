// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Введите координату X первой точки : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки : ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки : ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки : ");
int z2 = Convert.ToInt32(Console.ReadLine());

double resRound = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между координатами равно {resRound}");
 
double Distance(int aX, int aY, int aZ, int bX,int bY, int bZ)
{
   return Math.Sqrt((aX - bX ) * ( aX - bX ) + (aY - bY ) * (aY - bY ) + (aZ - bZ) * (aZ - bZ));
}