namespace Array
{
    public class ArrayFunctions
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxSequence = 0, currentSequence = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                    
                    currentSequence = 0;

                }
            }

            return (maxSequence > currentSequence) ? maxSequence : currentSequence;
        }
    }
}