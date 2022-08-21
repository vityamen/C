int[] array = {12,210,36,44,53,210,71,18,29};

int n = array.Length;
int find = 210;

int index = 0;

while (index < n){

    if(array[index]== find){
      Console.WriteLine(index); 
      break; 
    }
    index++;

} 