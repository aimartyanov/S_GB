int a = new Random().Next(4,15);
int[] array = new int[a];
int ArrLen(int a)
{
int len = 0;
if (a % 2 == 0)
{
len = a/2;
}
else
{
len = a/2+1;
}
return len;
}
int[] array2 = new int[ArrLen(a)];
void Fill(int[] arr)
{
    for (int i = 0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next(1,5);
    }
}
Fill(array);
void PrintAr(int[] arr)
{
for (int i = 0;i<arr.Length;i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}
PrintAr(array);
int[] NewArr(int[] arr,int[] arr2)
{
int k =0;
int l =1;
int m = 0;
while (k<arr.Length && l <= arr.Length && m < arr2.Length)
{
    arr2[m] = arr[k] *arr[^l];
    k++;
    l++;
    m++;
    if(m ==arr2.Length-1)
    {
    arr2[m] = arr[^m];
    }
}
return arr2;
}
PrintAr(NewArr(array,array2));
