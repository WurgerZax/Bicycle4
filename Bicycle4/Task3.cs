namespace Bicycle4;

public class Task3
{
    public int[] MergeAndSort(int[] arr1, int[] arr2)
    {
        int[] mergedArray = new int[arr1.Length + arr2.Length];
        int mergedArrayIndex = 0;
        
        int firstArrayPointer = 0;
        int secondArrayPointer = 0;

        while (true)
        {
            if (mergedArrayIndex >= mergedArray.Length) break;

            if (firstArrayPointer >= arr1.Length)
            {
                AddThoseWhoLeft(ref mergedArray, mergedArrayIndex, secondArrayPointer, arr2);
                break;
            }

            if (secondArrayPointer >= arr2.Length)
            {
                AddThoseWhoLeft(ref mergedArray, mergedArrayIndex, firstArrayPointer, arr1);
                break;
            }
            
            if (arr1[firstArrayPointer] < arr2[secondArrayPointer])
            {
                mergedArray[mergedArrayIndex] = arr1[firstArrayPointer];
                firstArrayPointer++;
            }
            else if (arr1[firstArrayPointer] > arr2[secondArrayPointer])
            {
                mergedArray[mergedArrayIndex] = arr2[secondArrayPointer];
                secondArrayPointer++;
            }
            else
            {
                mergedArray[mergedArrayIndex] = arr1[firstArrayPointer];
                mergedArrayIndex++;
                mergedArray[mergedArrayIndex] = arr2[secondArrayPointer];
            }
            mergedArrayIndex++;
        }
        
        return mergedArray;
    }

    private void AddThoseWhoLeft(ref int[] source, int sourceIndex, int fromIndex, int[] what)
    {
        for (int i = fromIndex; i < what.Length; i++)
        {
            source[sourceIndex] = what[i];
        } 
    }
}