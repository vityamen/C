/*
Написать программу проверяющую является ли второе число квадратом первого
*/
int userNumber1 = new int();
Console.Write("Введите число 1: ");
userNumber1 = Convert.ToInt32(Console.ReadLine());

int userNumber2 = new int();
Console.Write("Введите число 2: ");
userNumber2 = Convert.ToInt32(Console.ReadLine());

int result = (userNumber1*userNumber1);

if (result == userNumber2){
    Console.WriteLine("Да");
    Console.WriteLine($"Степень числа {userNumber1} = {userNumber2}");
    }
else{
    Console.WriteLine("Нет");
}

