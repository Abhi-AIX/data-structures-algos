Console.WriteLine("====================Greedy=====================");

Console.WriteLine("====================Divide And Conquer=====================");
Console.WriteLine("Polynamial Multiplication:");
PolynamialMultiplication pm = new PolynamialMultiplication();
int[] A = { 2, 4 };
int[] B = { 3, 1 };
int[] resultArray = pm.Multiply(A, B);
Console.WriteLine($"{string.Join(",", resultArray)}");

Console.WriteLine();
Console.WriteLine("Recursion PrintOne:");
Fundamental.Print();

Console.WriteLine();
Factorial fc = new Factorial();
Console.WriteLine(fc.FunctionalRecursion(3));
Console.WriteLine(fc.ParamerterizedRecursion(4,1));

