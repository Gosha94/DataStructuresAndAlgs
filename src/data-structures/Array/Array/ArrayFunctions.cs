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

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var firstArrCurrPtr = m - 1;
            var secondArrCurrPtr = n - 1;
            var lastMaxElemPtr = m + n - 1;

            while (lastMaxElemPtr >= 0)
            {
                if (firstArrCurrPtr >= 0 && secondArrCurrPtr >= 0)
                {
                    if (nums1[firstArrCurrPtr] >= nums2[secondArrCurrPtr])
                    {
                        nums1[lastMaxElemPtr--] = nums1[firstArrCurrPtr--];
                    }
                    else
                    {
                        nums1[lastMaxElemPtr--] = nums2[secondArrCurrPtr--];
                    }
                }
                else if (secondArrCurrPtr >= 0)
                {
                    nums1[lastMaxElemPtr--] = nums2[secondArrCurrPtr--];
                }
                else
                {
                    break;
                }
                
            }
        }

        public static int RemoveElement(int[] numsArr, int valueForDelete)
        {
            var iterationPointer = 0;
            var lastElemPointer = numsArr.Length - 1;

            while (iterationPointer <= lastElemPointer)
            {
                if (numsArr[iterationPointer] == valueForDelete)
                {
                    if (numsArr[lastElemPointer] == valueForDelete)
                    {
                        lastElemPointer--;
                        continue;
                    }

                    var temp = numsArr[iterationPointer];

                    numsArr[iterationPointer] = numsArr[lastElemPointer];
                    numsArr[lastElemPointer--] = temp;
                }

                iterationPointer++;
            }

            return ++lastElemPointer;
        }

        public static int RemoveDuplicates(int[] numsArr)
        {
            int uniquePointer = 0;
            int enumeratePointer = uniquePointer + 1;

            while (enumeratePointer < numsArr.Length)
            {

                if (numsArr[uniquePointer] != numsArr[enumeratePointer])
                {
                    numsArr[++uniquePointer] = numsArr[enumeratePointer];
                }

                enumeratePointer++;
            }

            return uniquePointer + 1;
        }

        public static bool CheckIfValueAndItsDoubleExistIn_HashSetVersion(int[] arr)
        {

            Array.Sort(arr);

            var map = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {

                if (i > 0 && arr[i] != 0)
                {
                    continue;
                }

                if (map.Contains(arr[i] * 2))
                {
                    return true;
                }

                map.Add(arr[i]);
            }

            return false;
        }

        public static bool CheckIfValueAndItsDoubleExistIn_BinarySearchVersion(int[] arr)
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                var indexOfFoundedElem = Array.BinarySearch(arr, arr[i] * 2);
                
                if (indexOfFoundedElem >= 0 && indexOfFoundedElem != i)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidMountainArray(int[] arr)
        {

            var leftPointer = 0;
            var rightPointer = arr.Length - 1;

            while (leftPointer < arr.Length - 1 && arr[leftPointer] < arr[leftPointer + 1])
            {
                leftPointer++;
            }

            while (rightPointer > 0 && arr[rightPointer - 1] > arr[rightPointer])
            {
                rightPointer--;
            }
            
            return leftPointer > 0 && leftPointer == rightPointer && rightPointer < arr.Length - 1;
        }

        public static int[] ReplaceEachValueToGreatestFromRightToLeftSide(int[] arr)
        {
            int[] resultArr = new int[arr.Length];
            Array.Copy(arr, resultArr, arr.Length);
            var maxToRightVal = -1;
            var temp = 0;

            for (int i = resultArr.Length - 1; i >= 0; i--)
            {
                if (resultArr[i] > maxToRightVal)
                {
                    temp = resultArr[i];
                    resultArr[i] = maxToRightVal;
                    maxToRightVal = temp;
                }
                else
                {
                    resultArr[i] = maxToRightVal;
                }
            }

            return resultArr;
        }

        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return;
            }

            int lastNotZeroPointer = 0;
            int searchNotZeroPointer = lastNotZeroPointer + 1;

            while (searchNotZeroPointer < nums.Length)
            {

                if (nums[lastNotZeroPointer] != 0)
                {
                    lastNotZeroPointer++;
                }

                if (nums[searchNotZeroPointer] != 0 && nums[lastNotZeroPointer] == 0)
                {
                    var temp = nums[lastNotZeroPointer];
                    nums[lastNotZeroPointer] = nums[searchNotZeroPointer];
                    nums[searchNotZeroPointer] = temp;

                    lastNotZeroPointer++;
                }
                searchNotZeroPointer++;
            }
        }

        public static int[] SortArrayByParity(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums;
            }

            int lastEvenNumbPointer = 0;
            int searchEvenNumbPointer = lastEvenNumbPointer + 1;

            while (searchEvenNumbPointer < nums.Length)
            {

                if (nums[lastEvenNumbPointer] % 2 == 0)
                {
                    lastEvenNumbPointer++;
                }

                if (nums[searchEvenNumbPointer] % 2 == 0 && nums[lastEvenNumbPointer] % 2 != 0 )
                {
                    var temp = nums[lastEvenNumbPointer];
                    nums[lastEvenNumbPointer] = nums[searchEvenNumbPointer];
                    nums[searchEvenNumbPointer] = temp;

                    lastEvenNumbPointer++;
                }
                searchEvenNumbPointer++;
            }

            return nums;
        }

        #endregion

    }
}