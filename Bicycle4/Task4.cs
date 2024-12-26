namespace Bicycle4;

public class Task4
{
    public bool IsArrayMonotonic(int[] array)
    {
        bool isIncreasing = false;
        bool isDecreasing = false;
        bool isMonotonic = true;

        for (int i = 0; i < array.Length; i++)
        {
            if (i + 1 >= array.Length) break;
            
            if (array[i] > array[i + 1])
            {
                isDecreasing = true;
                if (isIncreasing)
                {
                    isMonotonic = false;
                    break;
                }
            }

            if (array[i] < array[i + 1])
            {
                isIncreasing = true;
                if (isDecreasing)
                {
                    isMonotonic = false;
                    break;
                }
            }
        }
        
        return isMonotonic;
    }
}