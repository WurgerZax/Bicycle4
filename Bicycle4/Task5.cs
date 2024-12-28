namespace Bicycle4;

public class Task5
{
    // now its done
    public byte[] FrequencySort(byte[] source)
    {
        int[] frequency = new int[256];

        byte[] arrayToReturn = new byte[source.Length];

        for (int i = 0; i < source.Length; i++)
        {
            frequency[source[i]]++;
        }

        int currentMaxByte = -1;
        int startIndex = 0;
        
        for (int i = 0; i < frequency.Length; i++)
        {
            currentMaxByte = SearchMaxIndex(frequency);

            int count = frequency[currentMaxByte];
            
            Array.Fill(arrayToReturn, (byte)currentMaxByte, startIndex, count);
            startIndex += count;
            frequency[currentMaxByte] = -1;
        }
        
        return arrayToReturn;
    }

    private int SearchMaxIndex(int[] freq)
    {
        int currentMax = -1;
        int currIndex = -1;
        
        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] > currentMax)
            {
                currentMax = freq[i];
                currIndex = i;
            }       
        }

        return currIndex;
    }
}