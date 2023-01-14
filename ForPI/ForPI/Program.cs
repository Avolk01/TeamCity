
static double Fact(int n)
{
    if (n < 1)
        return 1;
    return n * Fact(n - 1);
}

//int n = int.Parse(Console.ReadLine());
var n = 10;
Console.WriteLine(Fact(n));

