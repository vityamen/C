/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/
void InitArray(int[] array){
    int length = array.Length;
    int index = 0;
    int result = 0;
    for(index = 0; index < array.Length; index++){
    Console.WriteLine("Введите число: ");
    array[index] = Convert.ToInt32(Console.ReadLine());
        if(array[index] > 0){
            result++;   
        } 
    }
    Console.WriteLine($"Пользователь ввел чисел: {result}, больше нуля");
}


void PrintArray(int[] array){
    int count = array.Length;
    int position = 0;
    while (position < count){
        Console.Write($"{array[position]}, ");
        position++;
    }
}

int[] array = new int[8];
InitArray(array);
Console.WriteLine();
PrintArray(array);

