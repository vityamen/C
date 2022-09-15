/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows,columns, 1,10);
PrintArray(array);
SumStringArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SumStringArray(int[,] array)
{
    int minSumStr = 0;
    int stringnum = 0;
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = sum[i] + array[i,j];           
        }
        Console.WriteLine($"сумма элементов {i} строки={sum[i]}"); 
    }

    
    for (int i = 0; i < sum.Length; i++)
    {
        if (i == 0)
        {
            minSumStr = sum[i];    
            stringnum = i;
        }
        else
        {   
            if(sum[i] <= minSumStr)
            {
            minSumStr = sum[i];
            stringnum = i;
            }
        } 
    }
    Console.WriteLine($"мин сумма строки = {minSumStr}");
    Console.WriteLine($"номер строки = {stringnum}");
}