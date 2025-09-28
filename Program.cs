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
Console.WriteLine("Recursion Factorial:");
Factorial fc = new Factorial();
Console.WriteLine(fc.FunctionalRecursion(3));
Console.WriteLine(fc.ParamerterizedRecursion(4,1));

Console.WriteLine();
Console.WriteLine("Recursion Reverse An Array:");
ReverseAnArray res = new ReverseAnArray();
int[] arr = { 1, 3, 4, 5, 6 };
int l = 0;int r = arr.Length-1;
res.ReverseArray(arr, 0, arr.Length - 1);


