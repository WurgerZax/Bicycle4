namespace Bicycle4;

public class Task6
{
    public int CalculateSubsequence(byte[] array)
    {
        int count = 0;

        int[] counts = new int[0];

        bool zeroUsed = false;
        
        int lastZeroIndex = -1;

        for (int i = 0; i <= array.Length; i++)
        {
            if (i >= array.Length || (array[i] == 0 && zeroUsed))
            {
                zeroUsed = false;
                count = Counter(array, i);
                Array.Resize(ref counts, counts.Length + 1);
                counts[counts.Length - 1] = count;
                array[lastZeroIndex] = 0;
            } 
            if (i < array.Length && array[i] == 0 && !zeroUsed)
            {
                array[i] = 1;
                lastZeroIndex = i;
                zeroUsed = true;
            }
        }
        
        var (number, index) = counts.Select((n, i) => (n, i)).Max();

        return number;
    }

    private int Counter(byte[] array, int endIndex)
    {
        int count = 0;
        
        for (int i = endIndex - 1; ; i--)
        {
            if (i == -1 || array[i] == 0)
            {
                return count;
            }
            count++;
        }
    }
}