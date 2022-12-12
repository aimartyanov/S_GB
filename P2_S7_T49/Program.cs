﻿int m = 3;
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
int[,] PowArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i %2 == 0 && j %2 ==0 && i > 0 && j > 0)
            array[i, j] *= array[i,j] ;
        }
    }
    return array;
}
int[,] array = new int[m, n];
FillArr(array);
PrintArr(array);
Console.WriteLine();

PrintArr(PowArr(array));