int n = 5;
int[] arr = { 2, 55, 7, 1, 73 };
int i=0;
int max = arr[0];
while (i < n) {
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i++;
}
Console.WriteLine(max);

