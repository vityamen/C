/*Задача 43: Напишите программу, которая найдёт точку пересечения двух
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double b1, b2, k1, k2, k, b;
double x=0, y=0;
Console.Write("Введите коэффициент уравнения b1:");
b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент уравнения b2:");
b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент уравнения k1:");
k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент уравнения k2:");
k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"y = {k1} * x + {b1}");
Console.WriteLine($"y = {k2} * x + {b2}");


b = b1 - b2;
k = k1 - k2;
x = b / -k;

Console.WriteLine(k1-k2);
Console.WriteLine(b1-b2);
y = k2*x + b2;
Console.WriteLine($"{x},{y}");

