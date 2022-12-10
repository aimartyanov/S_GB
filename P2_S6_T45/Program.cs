Console.Write("Input ");
int c = Convert.ToInt32(Console.ReadLine());
int[] a = new int[c];
int[] b = new int[a.Length];
void FillArr(int[] arr)
{
for (int i =0;i<arr.Length;i++)
{
    arr[i] = new Random().Next(1,100);
}
}
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length;i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
FillArr(a);
void Copy(int[] arr, int[] arr2)
{
    for (int i = 0; i< arr.Length;i++)
    {
        arr2[i] = arr[i];
    }
}
Copy(a,b);
Print(a);
Print(b);