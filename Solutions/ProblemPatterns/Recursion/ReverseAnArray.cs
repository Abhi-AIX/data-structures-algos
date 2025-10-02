// Visual for this example is available at: Assets/ReverseArray.svg
public class ReverseAnArray
{
    public void ReverseArrayTwoPointer(int[] arr, int l, int r)
    {
        if (l >= r)
        {
            PrintArray(arr);
            return;
        }

        int temp = arr[l];
        arr[l] = arr[r];
        arr[r] = temp;

    // recurse into itself for the standard two-pointer reversal
    ReverseArrayTwoPointer(arr, l + 1, r - 1);

    }

    public void ReverseArrayOnePointer(int[] arr, int n, int i)
    {
        if (i >= n / 2)
        {
            PrintArray(arr);
            return;
        }

        int temp = arr[i];
        arr[i] = arr[(n - i) - 1];
        arr[(n - i) - 1] = temp;

        ReverseArrayOnePointer(arr, i + 1, n);
    }


    public void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
    }

    //Experimental
    //Visual available at assets/ReverseArrayTwoPointerBackTracking.svg
    public void ReverseArrayTwoPointerBackTracking(int[] arr, int l, int r)
    {
        if (l >= r)
        {
            return;
            //If you print array here you will simply print same array because our swapping is done after we found our base case
        }

    // recurse into the backtracking version so swaps happen while unwinding
    ReverseArrayTwoPointerBackTracking(arr, l + 1, r - 1);

        int temp = arr[l];
        arr[l] = arr[r];
        arr[r] = temp;

    }
    
    
}