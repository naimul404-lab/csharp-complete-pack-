static int Add(int left, int right) => left + right;
static long Factorial(int n)
{
    if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "Must be non-negative.");
    return n <= 1 ? 1 : n * Factorial(n - 1);
}

Console.WriteLine(Add(12, 8));
Console.WriteLine(Factorial(5));
