int userNumberOne = new int();
int userNumberTwo = new int();
int userNumberThree = new int();

Console.WriteLine("Введите первое число: ");
userNumberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
userNumberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
userNumberThree = Convert.ToInt32(Console.ReadLine());

string GetTriangle(int a, int b, int c)
{
string result = string.Empty;
if (a < b + c && b < a + c && c < a + b){
    result = "Треугольник может существовать!";
}
else{
    result = "Не треугольник!";
}
return result;
}

GetTriangle(userNumberOne, userNumberTwo, userNumberThree);
string Check;
Check = GetTriangle(userNumberOne, userNumberTwo, userNumberThree);
Console.WriteLine(Check);
