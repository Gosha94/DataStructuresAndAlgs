using System.Text;

namespace Challenges.math_funcs;

/// <summary>
/// Функции для работы с большими числами, которые не помещаются в стандартные типы данных .NET
/// </summary>
public class HugeNumericsFunctions
{
    public static string SumTwoBigNumbers(string firstNumber, string secondNumber)
    {
        
        if (firstNumber.Any(ch => !char.IsNumber(ch)) || secondNumber.Any(ch => !char.IsNumber(ch)))
        {
            return "";
        }

        var mainNumber = string.Empty;
        var tinyNumber = string.Empty;

        if (firstNumber.Length > secondNumber.Length)
        {
            mainNumber = firstNumber;
            tinyNumber = secondNumber;
        }
        else
        {
            mainNumber = secondNumber;
            tinyNumber = firstNumber;
        }

        var mainCurrentIndex = mainNumber.Length - 1;
        var secondCurrentIndex = tinyNumber.Length - 1;

        var tempStack = new Stack<int>();
        var currentReminder = 0;
        int sum = 0;

        while (mainCurrentIndex >= 0)
        {

            var currentNumb1 = mainNumber[mainCurrentIndex];

            if (secondCurrentIndex >= 0)
            {
                var currentNumb2 = tinyNumber[secondCurrentIndex];

                sum = ToInt(currentNumb1) + ToInt(currentNumb2) + currentReminder;
                
                currentReminder = 0;
                secondCurrentIndex--;
            }
            else
            {
                sum = ToInt(currentNumb1) + currentReminder;                
            }

            mainCurrentIndex--;

            int digitCount = (int)Math.Log10(sum) + 1;

            if (digitCount == 2)
            {
                sum -= 10;
                currentReminder = 1;
            }

            tempStack.Push(sum);
            
        }

        var resultStr = new StringBuilder();

        if (currentReminder == 1)
        {
            resultStr.Append(currentReminder.ToString());
        }

        while (tempStack.Count > 0)
        {
            resultStr.Append(tempStack.Pop().ToString());
        }        

        return resultStr.ToString();
    }

    private static int ToInt(char c)
    {
        return (int)(c - '0');
    }

}