public class ReverseAnArray
{
    public void ReverseArray(int[] arr, int l, int r)
    {
        if (l >= r)
        {
            PrintArray(arr);
            return;
        }

        int temp = arr[l];
        arr[l] = arr[r];
        arr[r] = temp;

        ReverseArray(arr, l + 1, r - 1);
    }


    public void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
    }
}