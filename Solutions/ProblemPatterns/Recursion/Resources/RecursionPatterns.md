# Recursion Patterns: Subsequences & Variants

This guide summarizes the four fundamental recursion/backtracking patterns based on **subsequence generation**.

Understanding these makes you fluent in recursion, backtracking, and dynamic programming foundations.

---

## Print All Subsequences

**Goal:** Print or return **all** possible subsequences of an array or string.

**Key Idea:**
- Each index decides: **include or exclude** current element.
- Explore both branches fully.
- No early stopping.

**Base Case:**
```csharp
if (index == nums.Length)
{
    result.Add(new List<int>(subset));
    return;
}
```

**Recursion Flow:**
```
            []
        /       \
     [1]         []
   /   \        /   \
 [1,2] [1]    [2]   []
```

**Output Example (nums = [1,2,3]):**
```
[], [3], [2], [2,3], [1], [1,3], [1,2], [1,2,3]
```

---

## Print All Subsequences Whose Sum == K

**Goal:** Print every subsequence whose sum equals a given `k`.

**Key Idea:**
- Carry an accumulating `sum`.
- Only add subset to result if `sum == k` at base case.

**Base Case:**
```csharp
if (index == nums.Length)
{
    if (sum == k)
        result.Add(new List<int>(subset));
    return;
}
```

**Recursion Tree Concept:**
Each node tracks `(index, sum, subset)`.  
At the end of recursion, all paths with `sum == k` are printed.

**Example (nums = [1,2,1], k = 2):**
```
[1,1], [2]
```

---

## Print Any One Subsequence Whose Sum == K

**Goal:** Find **one** valid subsequence that satisfies `sum == k`.

**Key Idea:**
- Same as previous, but **short-circuit** once found.
- Return `true` to stop further recursive calls.

**Base Case:**
```csharp
if (index == nums.Length)
{
    if (sum == k)
    {
        result.Add(new List<int>(subset));
        return true;
    }
    return false;
}
```

**Return Logic:**
```csharp
subset.Add(nums[index]);
if (Backtrack(..., sum + nums[index], index + 1, subset))
    return true;

subset.RemoveAt(subset.Count - 1);
if (Backtrack(..., sum, index + 1, subset))
    return true;

return false;
```

**Behavior:**
- Returns as soon as the **first valid subsequence** is found.
- Other branches are **skipped** (gray/dashed in recursion tree).

**Example:**
```
nums = [1,2,1], k = 2
→ Output: [1,1]
```

---

## Count All Subsequences Whose Sum == K

**Goal:** Count how many subsequences have sum equal to `k`.

**Key Idea:**
- Instead of printing or short-circuiting, **return integer counts**.
- Every recursive call returns a count from left and right branches.

**Return Expression:**
```csharp
int left = Backtrack(nums, result, k, sum + nums[index], index + 1, subset);
int right = Backtrack(nums, result, k, sum, index + 1, subset);
return left + right;
```

**Conceptual View:**
- Left = include current element
- Right = exclude current element
- Each leaf returns `1` if `sum == k`, else `0`
- Parent node sums both.

**Example (nums = [1,2,1], k = 2):**
```
Subsequences: [1,1], [2]
Total Count = 2
```

---

## Recursion Pattern Summary

| Pattern | Goal | Return Type | Stops Early? | Output Example |
|----------|------|--------------|---------------|----------------|
| **Print All** | Show all subsequences | void / list | ❌ | `[1,2]`, `[1]`, `[2]`, `[]` |
| **Print Sum == K** | All matching subsequences | void / list | ❌ | `[1,1]`, `[2]` |
| **Print Any One** | Stop at first valid subsequence | bool | ✅ | `[1,1]` |
| **Count All** | Count total matches | int | ❌ | `2` |

---

### 🔍 Why These Patterns Matter
- Form the **core logic** of subset, combination, and permutation problems.
- Build understanding for **DFS**, **backtracking**, and **dynamic programming**.
- Enhance ability to visualize **decision trees** and **base case logic**.

