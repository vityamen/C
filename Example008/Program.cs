int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(arg2 > result)  result = arg2;
    if(arg3 > result)  result = arg3;
    return result;
}

int a1 = 21;
int b1 = 1;
int c1 = 66;
int a2 = 6;
int b2 = 5;
int c2 = 56;
int a3 = 12;
int b3 = 10;
int c3 = 100;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
int max = Max(
    Max (a1, b1, c1),
    Max (a2, b2, c2),
    Max (a3, b3, c3));
//int max = Max(max1, max2, max3);
Console.WriteLine("Максимальное число: " +max);
