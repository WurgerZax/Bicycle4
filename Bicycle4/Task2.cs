namespace Bicycle4;

public class Task2
{
    public int FindMostCommonByte(byte[] bytesInputArray)
    {
        int previousCount = 0;
        byte previousByte = 0;
        
        int mostCommonByte = 0;
        
        for (int i = 0; i < bytesInputArray.Length; i++)
        {
            if(previousByte == bytesInputArray[i] && i != 0) continue;
            byte currentByte = bytesInputArray[i];
            
            int currentCount = CountValueInArray(bytesInputArray, currentByte);

            if (currentCount > previousCount)
            {
                previousCount = currentCount;
                previousByte = currentByte;
                
                mostCommonByte = currentByte;
            }

            if (currentCount == previousCount)
            {
                mostCommonByte = Math.Min(currentByte, previousByte);
            }
        }
        
        return mostCommonByte;
    }

    private int CountValueInArray(byte[] bytesInputArray, byte value)
    {
        int count = 0;
        
        for (int i = 0; i < bytesInputArray.Length; i++)
        {
            if (bytesInputArray[i] == value)
            {
                count++;
            }
        }
        
        return count;
    }
}