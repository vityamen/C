/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив
строк, длина которых меньше или равна 3 символа. Первоначальный массив
ввести с клавиатуры.

Пример:
["Hello", "2", "world", :-)] -> ["2", ":-)"]
*/

Console.Clear();
Console.Write("Введите количество слов в строке: ");
int size = int.Parse(Console.ReadLine());

string[] array = GetArray(size);
PrintArray(array);
Console.WriteLine();
string[] newArray = ChangeArray(array);
Console.WriteLine();
string[] result = ReplaceArray(newArray);
PrintArray(result);


string[] GetArray(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите значение {i} слова:");
        result[i] = Console.ReadLine();
    }
    return result;
}

void PrintArray(string[] array)
{
    for(int i= 0; i < array.GetLength(0); i++)
    {
        int length = array.GetLength(0);
        { 
        if(i < length-1)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else Console.Write($"\"{array[i]}\"");
        }
    }
}

string[] ChangeArray(string[] array)
{
    string[] result = new string[array.GetLength(0)];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[i] = array[i];
        }
        else 
            result[i] = "";
    }
    return result;
}

string[] ReplaceArray(string[] array)
{
    string[] newmass = new string[array.Length];
    int j=0;
    for (int i = 0; i < array.Length; i++)
    {
        int length = array[i].Length;
        if (length > 0)
        {
            newmass[j] = array[i];
            j++;
        }
    }
    string[] result = new string[j];
    
    for (int i = 0; i < j; i++)
    {
        result[i] = newmass[i];
    }
    return result;
}
