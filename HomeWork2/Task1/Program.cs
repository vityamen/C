/*
 Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int GetNumRandinRange(int MinNum, int MaxNum)
{
    int results = new Random().Next(MinNum, MaxNum+1);
    return results;
}

int GetSecondDigitFromNumber(int number)
{
    int first = number % 100;
    int result = first / 10;
    return result;
}


int RandNum = GetNumRandinRange(100, 999);
int SecondDigit = GetSecondDigitFromNumber(RandNum);
Console.WriteLine($"{RandNum} : {SecondDigit}");
