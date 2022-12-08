namespace FloydsCycleDetection
{
    public class DuplicateFinder
    {

        public static int FindDuplicateNumber(int[] numbersArr)
        {
            var tortoise = numbersArr[0];
            var hare = numbersArr[0];

            while (true)
            {
                tortoise = numbersArr[tortoise];
                hare = numbersArr[numbersArr[hare]];
                
                if (tortoise == hare) { break; }
            }

            var pointer1 = numbersArr[0];
            var pointer2 = tortoise;

            while (pointer1 != pointer2)
            {
                pointer1 = numbersArr[pointer1];
                pointer2 = numbersArr[pointer2];
            }

            return pointer1;

        }
    }
}