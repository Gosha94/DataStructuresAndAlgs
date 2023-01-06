using System.Text;

namespace Challenges.strings_algs
{
    public class StringFormatter
    {

        /// <summary>
        /// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
        /// Time Complexity O(magazine.length)/ Space Complexity O(symbDict.Keys.Count())
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public static bool CanConstruct(string ransomNote, string magazine)
        {

            var symbDict = magazine.GroupBy(g => g).ToDictionary(k => k.Key, v => v.Count());

            var chArrr = ransomNote.ToCharArray();

            foreach (var ch in chArrr)
            {
                
                if (symbDict.ContainsKey(ch) && symbDict[ch] > 0)
                {
                    symbDict[ch] --;
                }
                else
                {
                    return false;
                }

            }

            return true;
        }

        /// <summary>
        /// Method changes format of string, trims spaces and grouping symbols. Rest of symbols goes to half-empty group
        /// </summary>
        /// <param name="numInEachGroup">Number of symbols in each group</param>
        /// <param name="inputStr">Input string</param>
        /// <returns></returns>
        public static string Reshape(int numInEachGroup, string inputStr)
        {
            var tmp = inputStr.Where(c => !char.IsWhiteSpace(c)).Select(c => c).ToArray();
            var res = string.Concat(tmp);
            var finalString = new List<string>();

            for (var i = 0; i < res.Length; i += numInEachGroup)
            {
                var sub = res.Substring(i, Math.Min(numInEachGroup, res.Length - i));
                finalString.Add(sub);
            }

            var builder = new StringBuilder();

            foreach (var elem in finalString)
            {
                builder.Append(elem + "\n");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
