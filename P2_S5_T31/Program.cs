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
int SumPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
int SumNeg(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] < 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
void Print(int sumpos, int sumneg,int[] array) 
{
    for (int i = 0; i < array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных {sumpos} ");
    Console.WriteLine($"Сумма отрицательных {sumneg} ");
}
Print(SumPos(array), SumNeg(array), array);