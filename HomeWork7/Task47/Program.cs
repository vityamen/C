// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами. 

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows,columns, -100,100);
PrintArray(array);

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