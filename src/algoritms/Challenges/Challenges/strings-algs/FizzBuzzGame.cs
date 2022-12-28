using System.Text;

namespace Challenges.strings_algs
{
    public class FizzBuzzGame
    {
        public static IList<string> PlayFizzBuzz(int n)
        {

            var resultList = new List<string>(n);

            for (int i = 1; i <= n; i++)
            {
                var isDivideByThree = i % 3 == 0;
                var isDivideByFive = i % 5 == 0;

                if (isDivideByThree && isDivideByFive)
                {
                    resultList.Add("FizzBuzz");
                }
                else if (isDivideByFive)
                {
                    resultList.Add("Buzz");
                }
                else if (isDivideByThree)
                {
                    resultList.Add("Fizz");
                }
                else
                {
                    resultList.Add(i.ToString());
                }
            }

            return resultList;
        }
    }
}