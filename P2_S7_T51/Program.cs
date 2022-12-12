int m = 3;
int n = 4;
void FillArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}
void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int SumArr(int[,] array)
{
    int sum =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            sum += array[i,j] ;
        }
    }
    return sum;
}
int[,] array = new int[m, n];
FillArr(array);
PrintArr(array);
Console.WriteLine();

Console.WriteLine(SumArr(array));