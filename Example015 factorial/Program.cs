
double Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial (n-1);
}
for(int i = 1; i < 41; i++)
{
    Console.WriteLine($"Факториал числа {i}! = {Factorial(i)}");
}

