Console.Write("Введите число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int Sum()
{
int sum =0;
for (int i=0;i<=x1;i++)
{
    sum+=i;
}
return sum;
}
void Print(int sum)
{
Console.WriteLine(sum);
}
Print(Sum());