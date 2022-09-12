/*
Задача 64: Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N
от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/

void FillArray(int[] collection, int M, int N){
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
    collection[index] =  M + index;
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

void SortArray(int[] arr){
    int count = arr.Length;
    int temp = 0;
    for (int i = 0; i < count; i++){
        for (int j = 0; j < count -1; j++){
            if (arr[i] > arr[j]){
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            }
        }
    }   
}


Console.Write("Введите первое число: M =");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: N =");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M-N+1];
FillArray(array, N , M);
SortArray(array);
FillPrint(array);
