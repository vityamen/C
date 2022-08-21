void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
    collection[index] = new Random().Next(0,10);
    index++; 
    }
}

void FillPrint(int[] coll){
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
    Console.WriteLine(coll[position]);
    position++; 
    }
}

int[] array = new int[10];

FillArray(array);
FillPrint(array);
