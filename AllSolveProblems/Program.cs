using System.Diagnostics;
using static System.Console;
using System.Globalization;
using System.Text.RegularExpressions;

namespace AllSolveProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var res = Solution.ProductExceptSelf([1, 2, 3, 4]);
            //var res = Solution.ProductExceptSelf([-1, 1, 0, -3, 3]);
            //foreach (var i in res) Write(i + " ");

            WriteLine(Solution.ReverseWords("the sky is blue"));
            WriteLine(Solution.ReverseWords("  hello   world  "));
            WriteLine(Solution.ReverseWords("a good   example"));

        }
        
    }
}
