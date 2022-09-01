/*
Принимает на вход число А и выводит сумму чисел от 1 до А
*/
Console.Clear();
Console.WriteLine("Введите число А");
int Num = int.Parse(Console.ReadLine());

int GetSumNumbers(int number)
{
    int sum = 0;
    int i = 1;
    while(i <= number)
    {
        sum +=i;
        i++;
    }
    return sum;
}
Console.WriteLine($"Сумма чисел от 1 до А={GetSumNumbers(Num)}");
