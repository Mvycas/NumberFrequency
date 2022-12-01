namespace FrequencyCalculator.Model;

public class Model
{
    public  int [] FindFrequency(int [] Array, int n)
    {
        int[] count = new int[n + 1];
        for (int i = 0; i < Array.Length; i++) 
        {
            count[Array[i]]++; 
        }
        return count;
    }
    
    public (int, int) FindMinMax(int[] NumberArray, int ArraySize)
    {
        int max = 0, min = 0;

        for(int i=0; i < ArraySize; i++)
        {
            if(NumberArray[i] > max)
            {
                max = NumberArray[i];
            }
            if(NumberArray[i] < min)
            {
                min = NumberArray[i];
            }
        }
      
        return (min, max); // Using tuples to return multiple values to the method caller :)
    }
    
    public int[] CreateArrayFromRange(int min, int max)
    {
        int[] array = new int[max+1];
      
        for (int i = min; i < array.Length; i++)
        {
            array[i] = i;
        }
        return array;
    }
}