/*Задача 50. Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
(на вход именно поступает позиция элемента,
можете разбить на две переменные или прописать в одну строку и
конвертировать в два числа, комментарии в конце семинара по этой задаче)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows,columns, 0,10);
PrintArray(array);

Console.WriteLine("Введите номер строки: ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int j = int.Parse(Console.ReadLine());
GetElemetFromIndex(array, i, j);

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

void GetElemetFromIndex(int[,] array, int i, int j)
{
    Console.WriteLine($"Элемент{i}{j} = {array[i,j]}");
}