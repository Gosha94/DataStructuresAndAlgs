using System;

namespace FloydsCycleDetection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = DuplicateFinder.FindDuplicateNumber(new int[] {3, 1, 1, 4, 2});
            Console.WriteLine(result);
        }
    }
}