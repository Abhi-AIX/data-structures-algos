// Visual for this example is available at: Assets/Factorail.svg
class Factorial
{
    //Parameterized recursion
    public int ParamerterizedRecursion(int i, int prod)
    {

        if (i == 1)
        {
            return prod;
        }

        return ParamerterizedRecursion(i - 1, prod * i);
    }

    //Functional Recursion
    public int FunctionalRecursion(int i)
    {

        if (i == 1)
        {
            return 1;
        }

        return i * FunctionalRecursion(i - 1);
    }


}