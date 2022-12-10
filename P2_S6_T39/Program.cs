Console.Write("Input ");
int c = Convert.ToInt32(Console.ReadLine());
int[] a = new int[c];
void Fill(int[] arr)
{
    for (int i = 0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next(1,5);
    }
}
void PrintAr(int[] arr)
{
for (int i = 0;i<arr.Length;i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}
Fill(a);
PrintAr(a);
//int[] b = int[a.Length];
void ConvArr(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length/2;i++)
    {
        temp = arr[arr.Length-i-1];
        arr[arr.Length-i-1] = arr[i];
        arr[i] = temp;
    }
}
ConvArr(a);
PrintAr(a);