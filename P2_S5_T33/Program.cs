int[] array = new int[12];
Console.Write("BB ");
int a = Convert.ToInt32(Console.ReadLine());
int[] Fill(int[] array)
{
for(int i=0;i<array.Length;i++)
{
    array[i] = new Random().Next(-15,20);
}
return array;
}
array = Fill(array);
bool ArGuess(int[] array, int num)
{
    bool a = false;
    for (int i = 0; i < array.Length;i++)
    {
        if(array[i] == num)
        {
            a =  true;
        }
        else a = false;
    }
    return a;
}
bool b = ArGuess(array,a);
void Print(bool b)
{
    if (b)
    {
        Console.WriteLine("y");
    }
    else
    {
        Console.WriteLine("n");
    }
}
Print(b);