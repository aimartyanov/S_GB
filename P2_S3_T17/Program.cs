Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a >0 && b>0)
{
    Console.WriteLine("1");
}
if (a <0 && b>0)
{
    Console.WriteLine("2");
}
if (a <0 && b<0)
{
    Console.WriteLine("3");
}
if (a >0 && b<0)
{
    Console.WriteLine("4");
}