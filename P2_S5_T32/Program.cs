int[] array = new int[12];
int[] Fill(int[] array)
{
for(int i=0;i<array.Length;i++)
{
    array[i] = new Random().Next(-9,10);
}
return array;
}
array = Fill(array);
int[] ArABS(int[] array)
{
    for (int i = 0;i< array.Length;i++)
    {
        if (array[i] < 0)
        {
            array[i] = Math.Abs(array[i]);
        }
        else
        {
            array[i] = array[i]*-1;
        }
    }
    return array;
}
void Print(int[] array) 
{
    Console.WriteLine();
    for (int i = 0; i < array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Print(array);
Print(ArABS(array));