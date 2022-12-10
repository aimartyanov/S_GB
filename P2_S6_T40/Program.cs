Console.Write("Input ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input ");
int c = Convert.ToInt32(Console.ReadLine());
if (a < (b+c) && b < (a+c) && c < (a+b)) 
Console.WriteLine("Yes");
else
Console.WriteLine("no");