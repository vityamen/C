/*string[,] table = new string[2,5];

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5;columns++)
    {
        Console.WriteLine($"-{table[rows,columns]}-");    
    }       
}*/

/*
int[,] matrix = new int[5,5];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5;j++)
    {
        Console.Write($"{matrix[i,j] }");    
    }       
    Console.WriteLine();
}
*/


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1);j++)
        {
            Console.Write($"{matr[i,j] }");    
        }       
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1);j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }       
    }    
}

int[,] matrix = new int[5,5];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
