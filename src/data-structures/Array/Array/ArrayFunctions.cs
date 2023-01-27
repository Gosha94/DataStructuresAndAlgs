namespace CustomArray
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

        public static int CountNumbersWithEvenDigits(int[] nums)
        {
            var evenCounter = 0;

            foreach (var num in nums)
            {
                var currentNum = num;
                var digitCounter = 0;

                while (currentNum > 0)
                {
                    currentNum /= 10;
                    digitCounter++;
                }

                if (digitCounter % 2 == 0)
                {
                    evenCounter++;
                }
            }

            return evenCounter;
        }

        public static int[] SortedSquares(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }

            Array.Sort(nums); 
            return nums;
        }

        public static void DuplicateZeros(int[] arr)
        {
            var lastZeroIndex = 0;

            while (lastZeroIndex < arr.Length - 1)
            {
                if (arr[lastZeroIndex] == 0)
                {
                    int lastTemp = 0;

                    for (var i = lastZeroIndex + 1; i <= arr.Length - 1; i++)
                    {
                        var nextTemp = arr[i];

                        arr[i] = lastTemp;
                        lastTemp = nextTemp;
                    }
                    lastZeroIndex += 2;
                }
                else
                {
                    lastZeroIndex++;
                }
            }
        }

        #endregion


    }
}