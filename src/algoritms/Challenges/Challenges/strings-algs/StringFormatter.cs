using System.Text;

namespace Challenges.strings_algs
{
    public class StringFormatter
    {

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
