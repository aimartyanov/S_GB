Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a%b ==0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine($"Не кратное, остаток от деления {a%b}");
}