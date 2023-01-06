using System.Text;

namespace Challenges.math_funcs
{
    public class IntegerFunctions
    {
       
        public static int GetNextClosestTo(int inputNumber)
        {
            var inputAsArr = inputNumber.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            var uniqueNumbersList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                if (!Array.Exists(inputAsArr, (elem) => elem == i))
                {
                    uniqueNumbersList.Add(i);
                }
            }

            var builder = new StringBuilder();

            var minUniqueNumber = uniqueNumbersList.Min();
            var headNumber = uniqueNumbersList.FirstOrDefault(x => x >= inputAsArr[0], minUniqueNumber);

            if (headNumber > inputAsArr[0])
            {
                while (builder.Length < inputAsArr.Length)
                {
                    if (builder.Length == 0)
                    {
                        builder.Append(headNumber);
                    }
                    else
                    {
                        builder.Append(minUniqueNumber);
                    }
                }
            }
            else
            {
                while (builder.Length <= inputAsArr.Length)
                {
                    if (builder.Length == 0)
                    {
                        builder.Append(headNumber);
                    }
                    else
                    {
                        builder.Append(minUniqueNumber);
                    }
                }
            }

            if (builder[0] == '0')
            {
                builder[0] = Convert.ToChar(uniqueNumbersList.FirstOrDefault(x => x > minUniqueNumber) + 48);
            }

            int resultVal = -1;
            int.TryParse(builder.ToString(), out resultVal);

            return resultVal;

        }

        public static int GetNextClosestTo_V2(int inputNumber)
        {
            var numbers = Enumerable.Range(0, 10).ToArray();

            var arrayNum = inputNumber.ToString().ToCharArray().Select(x => x - '0').ToArray();
            int? minNum = null;
            int? maxNum = null;
            bool hasZero = false;
            foreach (var n in numbers)
            {
                if (!arrayNum.Any(x => x == n))
                {
                    if (minNum == null && n != 0)
                    {
                        minNum = n;
                    }

                    if (n > arrayNum[0])
                    {
                        maxNum = n;
                        break;
                    }
                }
                else
                {
                    if (n == 0)
                    {
                        hasZero = true;
                    }
                }
            }
            var size = arrayNum.Count();
            var result = new StringBuilder();
            if (maxNum == null)
            {
                size++;
                maxNum = minNum;
            }

            result.Append(maxNum);
            for (int i = 1; i < size; i++)
            {
                if (hasZero)
                    result.Append(minNum);
                else
                    result.Append("0");
            }

            int resultVal = -1;
            int.TryParse(result.ToString(), out resultVal);

            return resultVal;

        }

        public static int GetReducingStepsToZero(int inputNumber)
        {
            
            var operationsCounter = 0;

            while (inputNumber > 0)
            {
                var isEven = inputNumber % 2 == 0;

                if (isEven)
                {
                    inputNumber /= 2;
                }
                else
                {
                    inputNumber--;
                }

                operationsCounter++;
            }

            return operationsCounter;
        }

        public static int GetReducingStepsToZero_V2(int inputNumber)
        {
            // Bit shift by 1 to the right if number is Even (check last  by bitmask 1)
            var operationsCounter = 0;

            while (inputNumber > 0)
            {
                var isEven = (inputNumber & 1) == 0;

                if (isEven)
                {
                    inputNumber >>= 1;
                }
                else
                {
                    inputNumber--;
                }

                operationsCounter++;
            }

            return operationsCounter;
        }

    }
}
