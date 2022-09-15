/*Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();
Console.Write("Введите количество строк матрицы: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы: ");
int columns = int.Parse(Console.ReadLine());
int[,] matrixA = GetMatrix(rows,columns, 1,10);
int[,] matrixB = GetMatrix(rows,columns, 1,10);

PrintMatrix(matrixA);
PrintMatrix(matrixB);

int[,] matrixC = new int[rows, columns];
matrixC = Multi(matrixA, matrixB);
PrintMatrix(matrixC);

int[,] GetMatrix(int m, int n, int min, int max)
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

void PrintMatrix(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Multi(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++) 
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}