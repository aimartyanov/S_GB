Console.Write("Введите число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int Pow(int x1)
{
int sum =1;
for (int i=1;i<=x1;i++)
{
    sum*=i;
}
return sum;
}
void Print(int sum)
{
Console.WriteLine(sum);
}
Print(Pow(x1));