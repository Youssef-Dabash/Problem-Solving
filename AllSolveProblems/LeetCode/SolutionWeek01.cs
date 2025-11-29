#region 283. Move Zeroes
/*
 
Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]

 */

//public class Solution
//{
//    public void MoveZeroes(int[] nums)
//    {
//        int[] arr = new int[nums.Length];
//        int i = 0;
//        foreach (var num in nums)
//        {
//            if (num != 0)
//                arr[i++] = num;
//        }

//        foreach (var item in arr)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}
#endregion


#region 13. Roman to Integer
/*
 
Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994

 */


//public class Solution
//{
//    public int RomanToInt(string s)
//    {
//        Dictionary<char, int> RomanNumeral = new Dictionary<char, int>()
//        {
//            { 'I', 1},
//            { 'V', 5},
//            { 'X', 10},
//            { 'L', 50},
//            { 'C', 100},
//            { 'D', 500},
//            { 'M', 1000}
//        };

//        int total = 0;
//        for (int i = 0; i < s.Length; i++) 
//        {
//            if (i + 1 < s.Length && RomanNumeral[s[i]] < RomanNumeral[s[i + 1]])
//            {
//                total -= RomanNumeral[s[i]];
//            }
//            else
//            {
//                total += RomanNumeral[s[i]];
//            }
//        }

//        return total; 
//    }
//}


//public class Solution
//{
//    public int RomanToInt(string s) // LVIII
//    {
//        int n = 0;
//        for (int i = 0; i < s.Length; i++)
//        {
//            if (i != s.Length - 1)
//            {
//                if (s[i] == 'I' && s[i + 1] == 'V') { n += 4; i++; continue; }
//                if (s[i] == 'I' && s[i + 1] == 'X') { n += 9; i++; continue; }

//                if (s[i] == 'X' && s[i + 1] == 'L') { n += 40; i++; continue; }
//                if (s[i] == 'X' && s[i + 1] == 'C') { n += 90; i++; continue; }

//                if (s[i] == 'C' && s[i + 1] == 'D') { n += 400; i++; continue; }
//                if (s[i] == 'C' && s[i + 1] == 'M') { n += 900; i++; continue; }
//            }
//            switch (s[i])
//            {
//                case 'I': n += 1; break;
//                case 'V': n += 5; break;
//                case 'X': n += 10; break;
//                case 'L': n += 50; break;
//                case 'C': n += 100; break;
//                case 'D': n += 500; break;
//                case 'M': n += 1000; break;
//            }
//        }
//        return n;
//    }
//}
#endregion


#region 14. LongestCommonPrefix
//Example 1:
//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"

//Example 2:
//Input: strs = ["dog", "racecar", "car"]
//Output: ""

//public class Solution
//{
//    public string LongestCommonPrefix(string[] strs)
//    {

//        string prefix = strs[0];
//        foreach (var str in strs)
//        {
//            while (!str.StartsWith(prefix))
//            {
//                //prefix = prefix.Substring(0, prefix.Length - 1);
//                prefix = prefix[..^1];
//                if (prefix.Equals("")) return string.Empty;
//            }
//        }
//        return prefix;
//    }
//}

#endregion


#region 347. TopKFrequentElements

//Example 1:
//Input: nums = [1, 1, 1, 2, 2, 3], k = 2
//Output: [1, 2]

//Example 2:
//Input: nums = [1], k = 1
//Output: [1]

//Example 3:
//Input: nums = [1, 2, 1, 2, 1, 2, 3, 1, 3, 2], k = 2
//Output: [1, 2]

//public class Solution
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


#region 20. ValidParentheses

//Example 1:
//Input: s = "()"
//Output: true

//Example 2:
//Input: s = "()[]{}"
//Output: true

//Example 3:
//Input: s = "(]"
//Output: false

//Example 4:
//Input: s = "([{}])"
//Output: true


//public class Solution
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


