class KaratsubaAlgorithm
{
    // Multiplies two numbers using Karatsuba's algorithm
    public static long Multiply(long x, long y)
    {
        // Base case for recursion
        if (x < 10 || y < 10)
            return x * y;

        // Calculate the size of the numbers
        int n = Math.Max(x.ToString().Length, y.ToString().Length);
        int m = n / 2;

        // Split the digit sequences about the middle
        long high1 = x / (long)Math.Pow(10, m);
        long low1 = x % (long)Math.Pow(10, m);
        long high2 = y / (long)Math.Pow(10, m);
        long low2 = y % (long)Math.Pow(10, m);

        // 3 recursive calls
        long z0 = Multiply(low1, low2);
        long z1 = Multiply((low1 + high1), (low2 + high2));
        long z2 = Multiply(high1, high2);

        return (z2 * (long)Math.Pow(10, 2 * m)) + ((z1 - z2 - z0) * (long)Math.Pow(10, m)) + z0;
    }
}