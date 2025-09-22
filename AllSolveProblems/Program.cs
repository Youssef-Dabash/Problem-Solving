using static System.Console;

namespace AllSolveProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Week 01

            SolutionWeek01 solution = new SolutionWeek01();

            var res = solution.LongestCommonPrefix(["flower", "flow", "flight"]);
            WriteLine(res);


            //var res = solution.TopKFrequent([1, 1, 1, 2, 2, 3], 2);
            //WriteLine(string.Join(", ", res));


            //var res = solution.IsValid("([{]})");
            //WriteLine(res);

            #endregion


        }
    }
}
