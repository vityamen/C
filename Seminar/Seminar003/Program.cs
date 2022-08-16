/*
Напишите программу, которая будет выдавать название дня недели
по заданному номеру. 3 -> Среда 5 -> Пятница
*/
int DayNumber = new int();
Console.Write("Введите номер дня недели: ");
DayNumber = Convert.ToInt32(Console.ReadLine());
if (DayNumber < 1 || DayNumber > 7) Console.WriteLine("Введите день от 1 до 7");
else if (DayNumber == 1) Console.WriteLine("Понедельник");
else if (DayNumber == 2) Console.WriteLine("Вторник");
else if (DayNumber == 3) Console.WriteLine("Среда");
else if (DayNumber == 4) Console.WriteLine("Четверг");
else if (DayNumber == 5) Console.WriteLine("Пятница");
else if (DayNumber == 6) Console.WriteLine("Суббота");
else if (DayNumber == 7) Console.WriteLine("Воскресенье");

