﻿double Fibonachi(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonachi(n-1)+Fibonachi(n-2);
}
for(int i = 1; i < 41; i++)
{
    Console.WriteLine($"Фибоначчи числа {i}! = {Fibonachi(i)}");
}