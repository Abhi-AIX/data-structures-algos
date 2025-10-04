//Visual Available at /Assets/ProblemPatterns/Recursion/PrintAllSubsequences.svg
class PrintAllSubsequnces
{

    public List<List<int>> PrintAllSubSequences(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();
        Backtracking(nums, result, 0, new List<int>());
        return result;
    }

    public void Backtracking(int[] nums, List<List<int>> result, int index, List<int> subset)
    {

        if (index == nums.Length)
        {
            result.Add(new List<int>(subset));
            return;
        }

        subset.Add(nums[index]);
        Backtracking(nums, result, index + 1, subset);

        subset.RemoveAt(subset.Count - 1);
        Backtracking(nums, result, index + 1, subset);
    }
}