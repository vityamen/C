/*
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает последнюю цифру этого числа.
456 -> 6 782 -> 2 918 -> 8
*/
int Number = new int();
int Number2 = new int();
Console.Write("Введите трехзначное число: ");
Number = Convert.ToInt32(Console.ReadLine());
Number2 = Number%10;
    Console.WriteLine(Number2);
