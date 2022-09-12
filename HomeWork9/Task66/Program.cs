/*
Задача 66:
Задайте значения M и N. Напишите программу,
которая найдёт сумму чётных чисел натуральных элементов
в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

void FillArray(int[] collection, int M, int N){
    int length = collection.Length;;
    int index = 0;
    while (index < length)
    {
    collection[index] = M + index;

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

int SumEvenNum(int[] arr){
    int count = arr.Length;
    int sum = 0;
    for (int i = 0; i < count; i++){
        if (arr[i]%2 == 0 ){
        sum = sum + arr[i];
        }
    } 
    return sum;
}

Console.Write("Введите первое число: M =");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: N =");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N-M+1];
FillArray(array, M , N);
FillPrint(array);
int sum = SumEvenNum(array);
Console.WriteLine($"Сумма четных чисел от {M} до {N}={sum}");