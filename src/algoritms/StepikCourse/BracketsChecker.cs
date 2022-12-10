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
            var bracketPairsDict = new Dictionary<char, char>()
            {
                { '[',']' },
                { '{','}' },
                { '(',')' },
            };

            var bracketsList = codeWithBrackets
                .Select((c, i) => new BracketItem { Char = c, Index = i, Position = i + 1 })
                .Where((c) => c.Char == '[' || c.Char == ']' || c.Char == '{' || c.Char == '}' || c.Char == '(' || c.Char == ')')
                .ToList();

            var openedBracketStack = new Stack<BracketItem>();

            string result = string.Empty;

            foreach (var item in bracketsList)
            {

                if (bracketPairsDict.ContainsKey(item.Char))
                {
                    openedBracketStack.Push(item);
                }
                else
                {
                    if (openedBracketStack.Count != 0)
                    {
                        if (bracketPairsDict[openedBracketStack.Pop().Char] != item.Char)
                        {
                            return item.Position.ToString();
                        }                        
                    }
                    else
                    {
                        return item.Position.ToString();
                    }
                }
            }

            if (openedBracketStack.Count > 0)
            {
                return openedBracketStack.Pop().Position.ToString();
            }
            else
            {
                return "Success";
            }
            

        }
    }

    public class BracketItem
    {
        public char Char { get; set; }
        
        public int Index { get; set; }

        public int Position { get; set; }
    }

}