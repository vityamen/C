﻿/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("Введите число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

if (Number1%2 == 0)
Console.WriteLine($"Число: {Number1} четное");
else Console.WriteLine($"Число {Number1} нечетное");

