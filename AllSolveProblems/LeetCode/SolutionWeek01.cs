using System.Text;
using System.Xml;

#region LongestCommonPrefix(14)
//Example 1:
//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"

//Example 2:
//Input: strs = ["dog", "racecar", "car"]
//Output: ""

public class SolutionWeek01
{
    public string LongestCommonPrefix(string[] strs)
    {

        string prefix = strs[0];
        foreach (var str in strs)
        {
            while (!str.StartsWith(prefix))
            {
                //prefix = prefix.Substring(0, prefix.Length - 1);
                prefix = prefix[..^1];
                if (prefix.Equals("")) return string.Empty;
            }
        }
        return prefix;
    }
}

#endregion

#region TopKFrequentElements(347)

//Example 1:
//Input: nums = [1, 1, 1, 2, 2, 3], k = 2
//Output: [1, 2]

//Example 2:
//Input: nums = [1], k = 1
//Output: [1]

//Example 3:
//Input: nums = [1, 2, 1, 2, 1, 2, 3, 1, 3, 2], k = 2
//Output: [1, 2]

//public class SolutionWeek01
//{
//    public int[] TopKFrequent(int[] nums, int k)
//    {
//        Dictionary<int, int> dict = new Dictionary<int, int>();
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (dict.ContainsKey(nums[i]))
//                dict[nums[i]]++;
//            else                
//                dict.Add(nums[i], 1);
//            //dict[nums[i]] = 1;
//        }
//        dict = dict.OrderByDescending(x => x.Value).ToDictionary();
//        int[] res = [..dict.Keys.Take(k)]; // Collection Expressions C# 12 feature
//        return res;


//        //return [..nums.GroupBy(x => x).OrderByDescending(g => g.Count()).Take(k).Select(g => g.Key)];
//    }
//}

#endregion

#region ValidParentheses(20)

////Example 1:
////Input: s = "()"
////Output: true

////Example 2:
////Input: s = "()[]{}"
////Output: true

////Example 3:
////Input: s = "(]"
////Output: false

////Example 4:
////Input: s = "([{}])"
////Output: true


//public class SolutionWeek01
//{
//    public bool IsValid(string s)
//    {
//        Stack<char> stack = new Stack<char>();
//        foreach (char c in s)
//        {
//            if (c == '(') stack.Push(')');
//            else if (c == '{') stack.Push('}');
//            else if (c == '[') stack.Push(']');
//            else if (stack.Count == 0 || stack.Pop() != c) return false;
//        }
//        return stack.Count == 0;
//    }
//}

#endregion