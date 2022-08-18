/*
Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int Number1 = new Random().Next(0,11);
int Number2 = new Random().Next(0,11);
int Number3 = new Random().Next(0,11);
int max;

Console.WriteLine($"Полученное число 1: {Number1}");
Console.WriteLine($"Полученное число 2: {Number2}");
Console.WriteLine($"Полученное число 3: {Number3}");

if (Number1 > Number2){
    max = Number1;
    if (max > Number3)
         Console.WriteLine("Максимальное число: "+max);
    else Console.WriteLine("Максимальное число2: "+Number3);
}

else {
    max = Number2;
    if (max > Number3)
         Console.WriteLine("Максимальное число : "+max);
    else Console.WriteLine("Максимальное число: "+Number3);
}

