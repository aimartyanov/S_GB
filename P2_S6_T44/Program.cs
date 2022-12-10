Console.Write("Input ");
int c = Convert.ToInt32(Console.ReadLine());
int[] a = new int[c];
void Feb(int[] a)
{
    a[0] = 0;
    a[1] = 1;
    for (int i=2;i< a.Length;i++)
    {
        a[i] = a[i - 1] + a[i-2];
    }
}
void Print(int[] a)
{
    for (int i=0; i <a.Length;i++ )
    {
        Console.Write($"{a[i]} ");
    }
}
Feb(a);
Print(a);