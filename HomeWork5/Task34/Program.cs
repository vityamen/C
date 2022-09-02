/*Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
    collection[index] = new Random().Next(99,999);
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

int FindEvenNum(int[] arr){
    int count = arr.Length;
    int position = 0;
    int EvenCount = 0;
    while (position < count)
    {
        if(arr[position]%2 == 0){
            //Console.WriteLine($"{position}");
            //Console.WriteLine($"{arr[position]}");
            EvenCount++;
            position++; 
        }    
        else position++;
    }   
    return EvenCount;
}

Console.Write("Введите размер массива: N =");
int Num = Convert.ToInt32( Console.ReadLine() );
int[] array = new int[Num];
FillArray(array);
FillPrint(array);
FindEvenNum(array);
Console.WriteLine($"Количество четных цифр в массиве = {FindEvenNum(array)}");
