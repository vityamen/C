/*
Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Clear();
Console.Write("Введите длину x матрицы: ");
int x= int.Parse(Console.ReadLine());

Console.Write("Введите длину y матрицы: ");
int y = int.Parse(Console.ReadLine());

Console.Write("Введите длину z матрицы: ");
int z = int.Parse(Console.ReadLine());

int[,,] matrix = GetMatrix(x, y, z, 10,100);


PrintMatrix(matrix);

int[,,] GetMatrix(int m, int n, int k, int min, int max)
{
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
            result[i, j, l] = new Random().Next(min, max);
            }
        }
    }
    return result;
}

void PrintMatrix(int[,,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1);j++)
        {
            for(int l=0; l < array.GetLength(1);l++)
            Console.Write($"{array[i,j,l]}{(i,j,l)}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}