/*
Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y)
*/

int GetCoordinateFromQuoter(int quoter)
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
