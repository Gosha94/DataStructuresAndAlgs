using System.Linq;

namespace StepikCourse
{

    /// <summary>
    /// Класс по работе с последовательностями скобок, проверки их на закрытие
    /// </summary>
    public class BracketsChecker
    {
        public string CheckBrackets(string codeWithBrackets)
        {
            //var bracketPairsDict = new Dictionary<char, char>()
            //{
            //    { '[',']' },
            //    { '{','}' },
            //    { '(',')' },
            //};

            var result = codeWithBrackets
                .Where((c) => c == '[' || c == ']' || c == '{' || c == '}' || c == '(' || c == ')')
                .Select((c, i) => new { c, i }).ToList();

            return "";

        }
    }
}