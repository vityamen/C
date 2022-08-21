/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа. 78 -> 8 12-> 2 85 -> 8
*/
int GetNumRandinRange(int MinNum, int MaxNum)
{
    int result = new Random().Next(MinNum, MaxNum+1);
    return result;
}

int GetMaxDigitFromNumber(int number)
{
    int result = number / 10;
    int secondDigit = number % 10;
    if(secondDigit > result)
    {
        result = secondDigit;
    }
    return result;
}

int RandNum = GetNumRandinRange(10, 99);
int MaxDigit = GetMaxDigitFromNumber(RandNum);
Console.WriteLine($"Наибольшая цифра двузначного числа: {RandNum}, будет: {MaxDigit}");

