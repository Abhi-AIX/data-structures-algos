//Visual Available at /Assets/ProblemPatterns/Recursion/PrintAllSequencesSumIsK.svg
class PrintAllSubsequncesSumIsK
{
    public List<List<int>> PrintAllSubSequencesSumIsK(int[] nums, int k)
    {
        List<List<int>> result = new List<List<int>>();
        Backtracking(nums, result, k, 0, 0, new List<int>());
        return result;
    }

    public void Backtracking(int[] nums, List<List<int>> result, int k, int sum, int index, List<int> subset)
    {

        if (index == nums.Length)
        {
            if (sum == k)
            {
                result.Add(new List<int>(subset));
            }
            return;
        }

        subset.Add(nums[index]);
        Backtracking(nums, result, k, sum + nums[index], index + 1, subset);

        subset.RemoveAt(subset.Count - 1);
        Backtracking(nums, result, k, sum, index + 1, subset);

    }
}