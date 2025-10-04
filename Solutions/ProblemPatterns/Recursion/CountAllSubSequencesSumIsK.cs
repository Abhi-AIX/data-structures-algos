//Visual Available at /Assets/ProblemPatterns/Recursion///Visual Available at /Assets/ProblemPatterns/Recursion/CountAllSubSequencesSumIsK.svg
class CountAllSubSequencesSumIsK
{
    public int CountAllSubsequencesSumIsK(int[] nums, int k)
    {
        List<List<int>> result = new List<List<int>>();
        return Backtracking(nums, result, k, 0, 0, new List<int>());
    }

    public int Backtracking(int[] nums, List<List<int>> result, int k, int sum, int index, List<int> subset)
    {
        if (index == nums.Length)
        {
            if (sum == k)
            {
                result.Add(new List<int>(subset));
                return 1;
            }
            return 0;
        }

        subset.Add(nums[index]);
        int left = Backtracking(nums, result, k, sum + nums[index], index + 1, subset);


        subset.RemoveAt(subset.Count - 1);
        int right = Backtracking(nums, result, k, sum, index + 1, subset);

        return left + right;
    }

}