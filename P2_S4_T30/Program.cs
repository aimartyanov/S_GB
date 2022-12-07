int[] array = new int[8];
int[] Fill(int[] array)
{
for(int i=0;i<array.Length;i++)
{
    array[i] = new Random().Next(0,2);
}
return array;
}
void Print(int[] array) 
{
for(int i=0;i<array.Length;i++)
{
    Console.Write($"{array[i]} ");
}
}
Print(Fill(array));
