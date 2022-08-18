/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
int i = new int();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
    for (i=0; i<=N; i++){
        if (i%2 == 0) { 
        Console.WriteLine($"Число: {i}");
        i = i + 1;
        }
    else i++;
    }
else {
    for (i=N; i<0; i++){
        if (i%2 == 0) { 
        Console.WriteLine($"Число: {i}");
        i = i + 1;
        }
    }    
}
