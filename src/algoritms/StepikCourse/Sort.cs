namespace StepikCourse
{
    public class Sort
    {

        public static int[] BubbleSort(int[] arrayForSort)
        {
            var operations = 0;

            return BubbleSort(arrayForSort,out operations);
        }

        public static int[] BubbleSort(int[] arrayForSort, out int totalOperations)
        {
            totalOperations = 0;

            totalOperations += 2;
            for (int i = 0; i < arrayForSort.Length - 1; i++)
            {
                totalOperations += 2;
                for (int j = 0; j < arrayForSort.Length - 1; j++)
                {

                    if (arrayForSort[j] > arrayForSort[j + 1])
                    {
                        var temp = arrayForSort[j];
                        arrayForSort[j] = arrayForSort[j + 1];
                        arrayForSort[j + 1] = temp;

                        totalOperations += 4;
                    }
                }
            }
            
            return arrayForSort;
        }
    }
}