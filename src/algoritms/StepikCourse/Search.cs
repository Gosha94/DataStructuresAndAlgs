namespace StepikCourse
{
    public class Search
    {
        public static int BinarySearch(int[] inputSortedArr, int numberForSearch, out int numOfOperations)
        {
            numOfOperations = 0;
            int lowIndex = 0;
            int highIndex = inputSortedArr.Length - 1;
            
            while (lowIndex <= highIndex)
            {
                numOfOperations++;

                int midIndex = (lowIndex + highIndex) / 2;
                
                if (inputSortedArr[midIndex] == numberForSearch)
                {
                    return midIndex;
                }
                
                if (inputSortedArr[midIndex] < numberForSearch)
                {
                    lowIndex = midIndex + 1;
                }
                else
                {
                    highIndex = midIndex - 1;
                }
            }
            
            return -1;

        }
    }
}