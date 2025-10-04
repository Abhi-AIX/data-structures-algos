Console.WriteLine("====================Divide And Conquer=====================");
Console.WriteLine("Polynamial Multiplication:");
PolynamialMultiplication pm = new PolynamialMultiplication();
int[] A = { 2, 4 };
int[] B = { 3, 1 };
int[] resultArray = pm.Multiply(A, B);
Console.WriteLine($"{string.Join(",", resultArray)}");

Console.WriteLine("====================Recursion=====================");
Console.WriteLine();
Console.WriteLine("Recursion PrintOne:");
FundamentalRecursion.Print();

Console.WriteLine();
Console.WriteLine("Recursion Factorial:");
Factorial fc = new Factorial();
Console.WriteLine(fc.FunctionalRecursion(3));
Console.WriteLine(fc.ParamerterizedRecursion(4,1));

Console.WriteLine();
Console.WriteLine("Recursion Reverse An Array (Two Pointer):");
ReverseAnArray res = new ReverseAnArray();
int[] arr = { 1, 5, 4, 3, 2, 6 };
int[] arr1 = { 5,4,2,1 };
int l = 0;int r = arr.Length-1;
res.ReverseArrayTwoPointer(arr, 0, arr.Length - 1);

Console.WriteLine();
Console.WriteLine("\nRecursion Reverse An Array (BackTracking):");
res.ReverseArrayTwoPointerBackTracking(arr1, 0, arr1.Length - 1);
res.PrintArray(arr1);

Console.WriteLine();
int n = arr.Length;
Console.WriteLine("\nRecursion Reverse An Array (One Pointer):");
res.ReverseArrayOnePointer(arr, 0, n);

Console.WriteLine();
Console.WriteLine("\nRecursion Valid Palindrome:");
ValidPalindrome vd = new ValidPalindrome();
vd.s = vd.s.Replace("[^a-zA-Z0-9]", "").ToLower();
Console.WriteLine(vd.ValidPalindromeRecursive(0, vd.s));


Console.WriteLine();
Console.WriteLine("\nRecursion Print All Subsequences:");
PrintAllSubsequnces pas = new PrintAllSubsequnces();

int[] nums = { 1, 2, 3 };
var subsequences = pas.PrintAllSubSequences(nums); // e.g. List<List<int>> or IEnumerable<IEnumerable<int>>

foreach (var seq in subsequences)
{
    Console.WriteLine("[" + string.Join(", ", seq) + "]");
}

Console.WriteLine();
Console.WriteLine("\nRecursion Print All Subsequences Whose sum is K:");
PrintAllSubsequncesSumIsK pask = new PrintAllSubsequncesSumIsK();

int[] nums1 = { 1, 2, 1 };
var subseqencesSumIsK = pask.PrintAllSubSequencesSumIsK(nums1, 2);

foreach (var seq in subseqencesSumIsK)
{
    Console.WriteLine("[" + string.Join(", ", seq) + "]");
}


Console.WriteLine();
Console.WriteLine("\nRecursion Print Any Subsequences Whose sum is K:");

PrintAnySubsequenceSumIsK asq = new PrintAnySubsequenceSumIsK();
var anySubseqencesSumIsK = asq.PrintAnySubSequencesSumIsK(nums1, 2);

foreach (var seq in anySubseqencesSumIsK)
{
    Console.WriteLine("[" + string.Join(", ", seq) + "]");
}

Console.WriteLine();
Console.WriteLine("\nRecursion Count All Subsequences Whose sum is K:");
CountAllSubSequencesSumIsK cas = new CountAllSubSequencesSumIsK();
Console.WriteLine(cas.CountAllSubsequencesSumIsK(nums1,2));