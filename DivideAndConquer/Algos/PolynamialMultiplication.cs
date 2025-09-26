public class PolynamialMultiplication
{
    /*
    Divide and Conqure Naive Approach
    */
    public int[] Multiply(int[] A, int[] B)
    {
        if (A.Length <= 1)
        {
            return new int[] { A[0] * B[0] };
        }

        int mid = A.Length / 2;

        int[] A_low = new int[mid];
        Array.Copy(A, 0, A_low, 0, mid);
        int[] A_high = new int[mid];
        Array.Copy(A, mid, A_high, 0, A.Length - mid);

        int[] B_low = new int[2];
        Array.Copy(B, 0, B_low, 0, mid);
        int[] B_high = new int[2];
        Array.Copy(B, mid, B_high, 0, B.Length - mid);

        int[] p1 = Multiply(A_high, B_high);
        int[] p2 = Multiply(A_high, B_low);
        int[] p3 = Multiply(A_low, B_high);
        int[] p4 = Multiply(A_low, B_low);

        int[] result = new int[A.Length + B.Length - 1];

        for (int i = 0; i < p4.Length; i++)
        {
            result[i] += p4[i];
        }

        for (int i = 0; i < p2.Length; i++)
        {
            result[i + mid] += p2[i];
        }

        for (int i = 0; i < p3.Length; i++)
        {
            result[i + mid] += p3[i];
        }

        for (int i = 0; i < p1.Length; i++)
        {
            result[i + 2 * mid] += p1[i];
        }

        return result;

        /*
        Reccurance Relationship
        - 4 * T(n/2)
        Big O
        - O(n^2)
        */
    }


    /*
    Karatsubha Algorithm
    */
     public int[] MultiplyKaratsubha(int[] A, int[] B){
        // --- 1. THE BASE CASE ---
        // This is our stopping condition. If the polynomials are just single
        // numbers (constants), we can multiply them directly.
        if (A.Length <= 1 || B.Length <= 1)
        {
            // If either is empty, the result is 0.
            if (A.Length == 0 || B.Length == 0) return new int[] { 0 };
            return new int[] { A[0] * B[0] };
        }

        // --- 2. THE DIVIDE STEP ---
        // We split the polynomials into two halves: a low-degree and a high-degree part.
        int n = Math.Max(A.Length, B.Length);
        int mid = n / 2;

        // Split A into A_low and A_high
        int[] A_low = A.Take(mid).ToArray();
        int[] A_high = A.Skip(mid).ToArray();

        // Split B into B_low and B_high
        int[] B_low = B.Take(mid).ToArray();
        int[] B_high = B.Skip(mid).ToArray();

        // --- 3. THE CONQUER STEP (THE "MAGIC TRICK") ---
        // We make the THREE recursive calls instead of four.

        // p1 = high * high
        int[] p1 = MultiplyKaratsubha(A_high, B_high);

        // p2 = low * low
        int[] p2 = MultiplyKaratsubha(A_low, B_low);

        // p3 = (A_high + A_low) * (B_high + B_low)
        int[] a_sum = Add(A_high, A_low);
        int[] b_sum = Add(B_high, B_low);
        int[] p3 = MultiplyKaratsubha(a_sum, b_sum);

        // --- 4. THE COMBINE STEP ---
        // This is where we assemble our final answer from the 3 pieces.

        // First, "unpack" p3 to get the true middle part.
        // middle_part = p3 - p1 - p2
        int[] middle_part_temp = Subtract(p3, p1);
        int[] middle_part = Subtract(middle_part_temp, p2);

        // Create the final result array. Its size is the sum of the degrees + 1.
        int[] result = new int[A.Length + B.Length - 1];

        // Now, add the 3 pieces into the result, shifting them to the correct "columns".
        // 

        // Add the low part (p2) with NO shift.
        for (int i = 0; i < p2.Length; i++)
        {
            result[i] += p2[i];
        }

        // Add the middle part with a shift of 'mid'.
        for (int i = 0; i < middle_part.Length; i++)
        {
            result[i + mid] += middle_part[i];
        }

        // Add the high part (p1) with a shift of '2 * mid'.
        for (int i = 0; i < p1.Length; i++)
        {
            result[i + 2 * mid] += p1[i];
        }

        return result;
    }

    // --- HELPER FUNCTIONS ---

    // Helper function to add two polynomials (arrays).
    public int[] Add(int[] p1, int[] p2)
    {
        int len = Math.Max(p1.Length, p2.Length);
        int[] sum = new int[len];
        for (int i = 0; i < len; i++)
        {
            int val1 = (i < p1.Length) ? p1[i] : 0;
            int val2 = (i < p2.Length) ? p2[i] : 0;
            sum[i] = val1 + val2;
        }
        return sum;
    }
    
    // Helper function to subtract one polynomial from another.
    public int[] Subtract(int[] p1, int[] p2)
    {
        int len = Math.Max(p1.Length, p2.Length);
        int[] diff = new int[len];
        for (int i = 0; i < len; i++)
        {
            int val1 = (i < p1.Length) ? p1[i] : 0;
            int val2 = (i < p2.Length) ? p2[i] : 0;
            diff[i] = val1 - val2;
        }
        return diff;
    }
}