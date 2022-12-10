Console.Write("Input ");
int a = Convert.ToInt32(Console.ReadLine());
void Conv(int a)
{
    string s = String.Empty;
    while (a > 0 )
    {
        s = Convert.ToString(a%2)+s;
        a/=2;
    }
    Console.WriteLine(s);
}
Conv(a);