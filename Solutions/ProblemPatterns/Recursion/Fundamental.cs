// Visual for this example is available at: /Assets/ProblemPatterns/Recursion/FundamentalRecursion.svg
class FundamentalRecursion
{
    //This function never ends because of no base case written.
    // public static void PrintOne()
    // {
    //     int i = 1;
    //     Console.WriteLine(i);
    //     PrintOne();
    // }

    static int count = 0;

    public static void Print()
    {
        if (count == 3)
        {
            return;
        }

        Console.WriteLine(count);
        count++;
        Print();
    }

}
