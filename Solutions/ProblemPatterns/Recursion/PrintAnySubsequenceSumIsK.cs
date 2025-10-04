//Visual Available at /Assets/ProblemPatterns/Recursion///Visual Available at /Assets/ProblemPatterns/Recursion/PrintAllSequencesSumIsK.svg

class PrintAnySubsequenceSumIsK
{
    public List<List<int>> PrintAnySubSequencesSumIsK(int[] nums, int k)
    {
        List<List<int>> result = new List<List<int>>();
        Backtracking(nums, result, k, 0, 0, new List<int>());
        return result;
    }

    public bool Backtracking(int[] nums, List<List<int>> result, int k, int sum, int index, List<int> subset)
    {

        if (index == nums.Length)
        {
            if (sum == k)
            {
                result.Add(new List<int>(subset));
                return true;
            }
            return false;
        }

        subset.Add(nums[index]);
        if (Backtracking(nums, result, k, sum + nums[index], index + 1, subset) == true)
        {
            return true;
        }

        subset.RemoveAt(subset.Count - 1);
        if (Backtracking(nums, result, k, sum, index + 1, subset) == true)
        {
            return true;
        }

        return false;
    }
}