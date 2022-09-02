/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
    collection[index] = new Random().Next(0,10);
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

int FindSumOdd(int[] arr){
    int count = arr.Length;
    int sum = 0;
    for(int position=1; position < count; position++){
        sum = sum + arr[position];
        position = position + 1;
    }     
    return sum;
}

Console.Write("Введите размер массива: N =");
int Num = Convert.ToInt32( Console.ReadLine() );
int[] array = new int[Num];
FillArray(array);
FillPrint(array);
Console.WriteLine($"Сумма нечетных элементов в массиве = {FindSumOdd(array)}");
