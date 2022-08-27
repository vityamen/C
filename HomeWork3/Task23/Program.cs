/*Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int Num = 0;
int i = 0;
Console.WriteLine("Введите число N");
Num = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= Num; i++)
{   
    
    double NewNum = Math.Pow(i,3);
    Console.Write($"{NewNum}, ");
}