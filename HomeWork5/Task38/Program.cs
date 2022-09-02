/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
    collection[index] = new Random().Next(-10,10);
    index++; 
    }
}

void FillPrint(int[] coll){
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
    Console.Write($"{coll[position]} ");
    position++; 
    }
    Console.WriteLine();
}

int FindMax(int[] arr){
    int count = arr.Length;
    int max = 0;
    int position=0;
    while( position < count){
        if (arr[position] > max){
            max = arr[position];
            position++;
        }
        else position++;
    }     
    return max;
}

int FindMin(int[] arr){
    int count = arr.Length;
    int min = 0;
    int position=0;
    min = arr[position];
    while( position < count){
        if (arr[position] < min){
            min = arr[position];
            position++;
        }
        else position++;
    }     
    return min;
}

Console.Write("Введите размер массива: N =");
int Num = Convert.ToInt32( Console.ReadLine() );
int[] array = new int[Num];
FillArray(array);
FillPrint(array);
Console.WriteLine($"Максимальный элемент в массиве = {FindMax(array)}");
Console.WriteLine($"Минимальный элемент в массиве = {FindMin(array)}");
int difference = FindMax(array) - FindMin(array);
Console.WriteLine($"Разница между {FindMax(array)} и {FindMin(array)} = {difference}");