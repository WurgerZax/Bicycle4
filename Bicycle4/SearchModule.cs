namespace Bicycle4;

public class SearchModule
{
    public int LinearSearch(int[] array, int value)
    {
        return LinearSearch(array, value, 0, array.Length - 1);
    }

    private int LinearSearch(int[] array, int value, int startIndex, int endIndex)
    {
        if (startIndex < 0 || startIndex > endIndex || startIndex > array.Length - 1)
        {
            throw new IndexOutOfRangeException();
        }
        
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (array[i] == value)
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    ///     Method will return correct result, only if input array is sorted
    /// </summary>
    /// <param name="array">sorted array</param>
    /// <param name="value">value to find</param>
    /// <returns>index of found element or -1</returns>
    public int BinarySearch(int[] array, int value)
    {
        return BinarySearch(array, value, 0, array.Length - 1);
    }

    private int BinarySearch(int[] array, int value, int startIndex, int endIndex)
    {
        int offset = (endIndex - startIndex) / 2;
        int middleIndex = startIndex + offset;
        
        int currentValue = array[middleIndex];

        if (startIndex == endIndex)
        {
            if (currentValue == value)
            {
                return middleIndex;
            }

            return -1;
        }
        
        if (currentValue == value)
        {
            return middleIndex;
        }

        if (currentValue < value)
        {
            startIndex = middleIndex + 1;
        }
        else
        {
            endIndex = middleIndex - 1;
        }
        
        return BinarySearch(array, value, startIndex, endIndex);
    }
}