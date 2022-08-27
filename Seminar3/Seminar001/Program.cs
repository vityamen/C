/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
в которой находится эта точка.
*/

int GetQuoterFromCoordinate(int x, int y)
{   
    int result = 0;
    if (x > 0 && y > 0 )
    {
        result = 1;
    }
    else if (x < 0 && y > 0)
    {
        result = 2;
    }
    else if (x < 0 && y < 0)
    {
        result = 3;
    }
    else if (x > 0 && y < 0)
    {
        result = 4;
    }
    else
    {
       Console.ForegroundColor = ConsoleColor.Red;
       Console.WriteLine($"X и У не должны быть равны 0 вы ввели {x} {y}");
       Console.ResetColor();
    }
    return result;
}
int userX = 0;
int userY = 0;
Console.WriteLine("Введите X: ");
userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
userY = Convert.ToInt32(Console.ReadLine());

int quoter = GetQuoterFromCoordinate(userX, userY);
Console.WriteLine($"Координаты {userX}:{userY} находятся в {quoter} четверти");


