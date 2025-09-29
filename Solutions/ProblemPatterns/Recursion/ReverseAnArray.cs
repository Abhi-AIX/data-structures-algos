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

        ReverseArrayTwoPointer(arr, l + 1, r - 1);
    }

    public void ReverseArrayOnePointer(int[] arr, int n, int i)
    {
        if (i >= n/2)
        {
            PrintArray(arr);
            return;
        }

        int temp = arr[i];
        arr[i] = arr[(n-i)-1];
        arr[(n-i)-1] = temp;

        ReverseArrayOnePointer(arr,i+1,n);
    }


    public void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
    }
}