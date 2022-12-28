namespace Array
{
    public class ArrayFunctions
    {

        #region Easy

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

        public static int[] GetEachElementSum(int[] nums)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                counter += nums[i];
                nums[i] = counter;
            }

            return nums;
        }

        public static int GetMaxRowSum(int[][] accounts)
        {
            var maxRowSum = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                var currRowSum = 0;

                for (int j = 0; j < accounts[i].Length; j++)
                {
                    currRowSum += accounts[i][j];
                }

                maxRowSum = Math.Max(maxRowSum, currRowSum);

            }
            
            return maxRowSum;
        }

        #endregion


    }
}