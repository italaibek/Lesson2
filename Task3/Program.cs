//int n = 10;
int[] array = { 2, 3, 5, 8, 7, 16, 6, 7, 32, 96 };
int i = 0;
//while(i<n){
while(i<array.Length){
    if(array[i]%2==0){
        Console.Write(array[i] + " ");
    }
    i++;
}
