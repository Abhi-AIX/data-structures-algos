// Visual for this example is available at: Assets/ReverseArray.svg
public class ValidPalindrome
{
    public string s = "aklmadkm39i203902##203 2";

    public bool ValidPalindromeRecursive(int i, string s)
    {

        if (i >= s.Length / 2)
        {
            return true;
        }

        if (s[i] != s[s.Length - i - 1])
        {
            return false;
        }

        return ValidPalindromeRecursive(i + 1, s);
    }
}