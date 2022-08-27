/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
string CheckThePolindrom(int N)
{
    string result = " ";
    int N1 = N/10000;
    int N2 = N/1000%10;
    int N3 = N/100%10;
    int N4 = N%100/10;
    int N5 = N%10;
    if ((N1 == N5) && (N2 == N4))
    {
        Console.WriteLine($"{N1}, {N2}, {N3}, {N4}, {N5}");
        result = "является полиндромом";
        return result;
    }

    else 
    {
        Console.WriteLine($"{N1}, {N2}, {N3}, {N4}, {N5}");
        result = "не является полиндромом";
        return result;
    }


}

int N = 0;
Console.WriteLine("Введите пятизначное число: ");
N = Convert.ToInt32(Console.ReadLine()); 
string Pol = CheckThePolindrom(N);
Console.WriteLine($"Введенное число: {N} {Pol} ");