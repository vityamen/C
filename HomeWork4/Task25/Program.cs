/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
*/

Console.Clear();
Console.WriteLine($"Введите число A= ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число B= ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числом {num1} в степени {num2} является {PowNum(num1,num2)}");

double PowNum(int a, int b)
{  
    int i = 0;
    double degree = 1;
    while(i < b)

    {           
        degree =degree*a;
        i++;
    }
    return degree;
}