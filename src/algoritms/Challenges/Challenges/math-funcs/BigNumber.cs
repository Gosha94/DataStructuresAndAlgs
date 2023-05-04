using System.Text;

namespace Challenges.math_funcs;

public class BigNumber
{
    
    private readonly int[] digits;

    public BigNumber(string x)
    {
        digits = x.Reverse()
            .Select(ch => ToInt(ch))
            .ToArray();
    }

    public override string ToString()
    {
        var sb = new StringBuilder(digits.Length);

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            sb.Append(digits[i]);
        }

        return sb.ToString();
    }

    public static BigNumber operator +(BigNumber a, BigNumber b)
    {

        int[] mainNumbArr;
        int[] tinyNumbArr;

        if (a.digits.Length > b.digits.Length)
        {
            mainNumbArr = a.digits;
            tinyNumbArr = b.digits;
        }
        else
        {
            tinyNumbArr = a.digits;
            mainNumbArr = b.digits;
        }

        var mainCurrentIndex = 0;
        var secondCurrentIndex = 0;
        var tempStack = new Stack<int>();
        var currentReminder = 0;
        int sum = 0;

        while (mainCurrentIndex <= mainNumbArr.Length - 1)
        {

            var currentNumb1 = mainNumbArr[mainCurrentIndex];

            if (secondCurrentIndex <= tinyNumbArr.Length - 1)
            {
                var currentNumb2 = tinyNumbArr[secondCurrentIndex];

                sum = currentNumb1 + currentNumb2 + currentReminder;

                currentReminder = 0;
                secondCurrentIndex++;
            }
            else
            {
                sum = currentNumb1 + currentReminder;
            }

            mainCurrentIndex++;

            int digitCount = (int)Math.Log10(sum) + 1;

            if (digitCount == 2)
            {
                sum -= 10;
                currentReminder = 1;
            }

            tempStack.Push(sum);
        }

        if (currentReminder != 0)
        {
            tempStack.Push(currentReminder);
        }

        var resultStr = new StringBuilder();

        while (tempStack.Count > 0)
        {
            resultStr.Append(tempStack.Pop());
        }

        return new BigNumber(resultStr.ToString());
    }

    private static int ToInt(char c)
    {
        return c - '0';
    }
}