int a = new Random().Next(10,99);
int f = a/10;
int l = a %10;
if (f > l)
{
    Console.WriteLine(f);
}
else
{
    Console.WriteLine(l);
}
