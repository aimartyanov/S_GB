 //Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
int Count(int x1)
{
int c=0;
while (x1!=0)
{
    x1=x1/10;
    c++;
}
return c;
}
void Print(int c)
{
Console.WriteLine($"{c}");
}
Console.Write("Введите число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Print(Count(x1));