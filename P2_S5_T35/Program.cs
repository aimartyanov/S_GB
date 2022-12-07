int[] array = new int[123];
int[] Fill(int[] array)
{
for(int i=0;i<array.Length;i++)
{
    array[i] = new Random().Next(1,1000);
}
return array;
}
array = Fill(array);
int ArrCount(int[] array)
{
    int c = 0;
    for (int i=0;i<array.Length;i++)
    {
        if(array[i]>=10 && array[i] <100)
        {
            c = c+1;
        }
    }
    return c;
}
void Print(int c,int[] array)
{
    for (int i = 0;i < array.Length;i++)
    {
    Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine(c);
}
Print(ArrCount(array),array);