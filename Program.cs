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