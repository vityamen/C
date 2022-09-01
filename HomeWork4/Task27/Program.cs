/*
Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write($"Введите число N= ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumAllDigit(num1));

int SumAllDigit(int number)
{   
    int digit = 0;
    int sum = 0;
    while( number != 0)
    {
        digit = number%10;
        number = number/10;
        sum = sum + digit;
        Console.Write($"{digit}, ");
    }
    Console.WriteLine();
    return sum;
}