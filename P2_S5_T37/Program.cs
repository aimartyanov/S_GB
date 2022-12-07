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
for (int i = 0;i<ArrLen(arr.Length);i++)
{
	arr2[i]=arr[i] * arr[arr.Length -1-i];
	if(arr.Length%2!= 0 && i==ArrLen(arr.Length) -1)
		arr2[i] = arr[i];
}


return arr2;
}
PrintAr(NewArr(array,array2));
Console.WriteLine(array.Length);
Console.WriteLine(array2.Length);
