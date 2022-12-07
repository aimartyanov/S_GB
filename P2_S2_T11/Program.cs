int a = new Random().Next(100,1000);
int b = a%10;
int c = (a/100)*10;
Console.WriteLine($"{b+c}");