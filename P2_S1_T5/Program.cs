Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = a-(a+a);i<=a;i++)
{
    Console.Write($"{i} ");
}