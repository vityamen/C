/*
Напишите программу, которая выводит случайное трёхзначное число
и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98
*/
int GetNumRandinRange(int MinNum, int MaxNum)
{
    int results = new Random().Next(MinNum, MaxNum+1);
    return results;
}

int GetSecondDigitFromNumber(int number)
{
    string first = Convert.ToString (number / 100);
    string second = Convert.ToString (number % 10);
    string resultStr = first+second;
    int resultInt = Convert.ToInt32(resultStr);
    return resultInt;
}


int RandNum = GetNumRandinRange(100, 999);
int SecondDigit = GetSecondDigitFromNumber(RandNum);
Console.WriteLine($"{RandNum} : {SecondDigit}");
