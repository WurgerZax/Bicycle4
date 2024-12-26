namespace Bicycle4;

public class Task5
{
    // not done yet
    public byte[] SortWithHighestFrequence(byte[] array)
    {
        byte[] bytes = new byte[256];

        byte[] arrayToReturn = new byte[array.Length];
        int arrayToReturnLastIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            bytes[array[i]]++;
        }
        for (int i = 0; i < bytes.Length; i++)
        {
            if(bytes[i] == 0) continue;

            for (int j = 0; j < bytes[i]; j++)
            {
                arrayToReturn[arrayToReturnLastIndex++] = (byte)i;
            }
        }

        return arrayToReturn;
    }
}