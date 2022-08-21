/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число от 1 до 7");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

string CheckDayOfWeek (int day)
{
    if (day == 6  || day == 7)
    {
        string result="Yes";
        return result;
    }
    
    else
    {
        string result="No";
        return result;
    }
}

if (DayOfWeek == 1) {Console.WriteLine("ПН");}
else if (DayOfWeek == 2) {Console.WriteLine("ВТ");}
else if (DayOfWeek == 3) {Console.WriteLine("СР");}
else if (DayOfWeek == 4) {Console.WriteLine("ЧТ");}
else if (DayOfWeek == 5) {Console.WriteLine("ПТ");}
else if (DayOfWeek == 6) {Console.WriteLine("СБ");}
else if (DayOfWeek == 7) {Console.WriteLine("ВС");}

string Check = CheckDayOfWeek(DayOfWeek);
Console.WriteLine(Check);