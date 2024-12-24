namespace Bicycle4;

public class Task1
{
    public int JumpSearch(int[] arr, int value)
    {
        int jump = (int)Math.Sqrt((double)arr.Length);
        
        int previousPosition = 0;

        for (int i = 0; i <= arr.Length; i+=jump)
        {
            if (i < arr.Length && arr[i] == value)
            {
                return i;
            }

            if (i >= arr.Length)
            {
                return SearchBackwards(arr, value, arr[^1], previousPosition);
            }
            
            if (arr[i] > value)
            {
                return SearchBackwards(arr, value, i, previousPosition);
            }   
            
            previousPosition = i;
        }
        
        return -1;
    }

    private int SearchBackwards(int[] arr, int value, int fromIndex, int toIndex)
    {
        for (int i = fromIndex - 1; i > toIndex; i--)
        {
            if (arr[i] == value)
            {
                return i;
            }
        }
        return -1;
    }
}