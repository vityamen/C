/*
Напишите программу, которая будет на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"
*/
int Number = new int();
int i=0;
Console.Write("Введите число: ");
Number = Convert.ToInt32(Console.ReadLine());
for (i= -Number; i<=Number; i++){
    Console.WriteLine(i);
}

