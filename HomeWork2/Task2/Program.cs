/*Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
string GetNumRandinRange(int MinNum, int MaxNum)
{
    string results = Convert.ToString (new Random().Next(MinNum, MaxNum+1));
    return results;
}

string GetThirdDigitFromNumber(string number)
{
    string lengthNumber = Convert.ToString(number.Length); 
      
    return lengthNumber;
}


string RandNum = GetNumRandinRange(10, 9999);
string ThirdDigit = GetThirdDigitFromNumber(RandNum);

Console.WriteLine($"{RandNum} в числе {ThirdDigit} цифр");

if (Convert.ToInt32(ThirdDigit) < 3)
{
    Console.WriteLine("третьей цифры нет!");
}

else if(Convert.ToInt32(ThirdDigit) == 3)
{
    int result =  Convert.ToInt32(RandNum) % 10;
    Console.WriteLine($"третья цифра: {result}");
}

if(Convert.ToInt32(ThirdDigit) == 4)
{
int result =  Convert.ToInt32(RandNum) % 100;
result = result / 10;
Console.WriteLine($"третья цифра: {result}");
}