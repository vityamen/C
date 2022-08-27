/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetDistanceFromCoordinate(int xa, int ya, int za, int xb, int yb, int zb)
{   
    double result = 0;
    result = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));
    return result;
}
int userXA = 0;
int userYA = 0;
int userZA = 0;
int userXB = 0;
int userYB = 0;
int userZB = 0;
Console.WriteLine("Введите координаты точки А");
Console.WriteLine("X: ");
userXA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
userYA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
userZA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В");
Console.WriteLine("X: ");
userXB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
userYB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
userZB = Convert.ToInt32(Console.ReadLine());

double distance = GetDistanceFromCoordinate(userXA, userYA, userZA, userXB, userYB,userZB);
Console.WriteLine($"Расстояние между A{userXA}{userYA}{userZA} и B {userXB}{userYB}{userZB} = {distance}");


