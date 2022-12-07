int[] array = new int[8];
int len = array.Length/2;
int[] array2 = new int[8];
{
    for (int i = 0; i<array.Length;i++)
    {
        array[i] = new Random().Next(1,5);
    }
}
for (int i = 0;i<array.Length;i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
/*for(int i =0;i<array.Length;i++)
{
    int j=1;
    array2[i] = array[i]*array[^j];
    j++;
}*/
int i =0;
int j =array.Length;
while (i<array.Length && j < 0)
{
    array2[i] = array[i] *array[^j];
    i++;
    j--;
}
for (int i = 0;i<array2.Length;i++)
{
    Console.Write($"{array2[i]} ");
}