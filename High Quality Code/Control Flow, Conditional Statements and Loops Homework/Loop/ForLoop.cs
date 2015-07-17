namespace Loop
{
    using System;

    public class ForLoop
    {
        public void FoundValueInPositionDivisibleByTen(int[] array, int value)
        {
            bool isValueFounded = false;

            for (int i = 0; i < array.Length; i++)
            {
                int currentValue = array[i];
                if (i % 10 == 0)
                {
                    if (currentValue == value)
                    {
                        isValueFounded = true;
                    }
                }
            }
          
            if (isValueFounded)
            {
                Console.WriteLine("Value Found");
            }
        }

        public void PrintValues(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int currentValue = array[i];
                Console.WriteLine(currentValue);
            }
        }
    }
}
