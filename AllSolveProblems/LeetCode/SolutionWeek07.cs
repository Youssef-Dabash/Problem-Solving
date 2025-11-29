
#region 594. Longest Harmonious Subsequence
/*
Example 1:
Input: nums = [1,3,2,2,5,2,3,7]
Output: 5


Example 2:
Input: nums = [1,2,3,4]
Output: 2

Example 3:
Input: nums = [1,1,1,1]
Output: 0
 */

using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

//public static class Solution
//{
//    // 1 2 3 5 7 key
//    // 1 3 2 1 1 value
//    public static int FindLHS(int[] nums) // [1,3,2,2,5,2,3,7]
//    {
//        int maxLen = default;
//        SortedList<int, int> sortDict = [];

//        #region fill SortedList
//        //for (int i = 0; i < nums.Length; i++)
//        //{
//        //    if (sortDict.ContainsKey(nums[i]))
//        //        sortDict[nums[i]]++;
//        //    else
//        //        sortDict[nums[i]] = 1;

//        //} 
//        #endregion

//        foreach (int n in nums)
//            sortDict[n] = sortDict.GetValueOrDefault(n) + 1;

//        for (int i = 1; i < sortDict.Count; i++)
//        {
//            if (sortDict.GetKeyAtIndex(i) - sortDict.GetKeyAtIndex(i - 1) == 1)
//            {
//                int len = sortDict.GetValueAtIndex(i) + sortDict.GetValueAtIndex(i - 1);
//                maxLen = Math.Max(maxLen, len);
//            }
//        }
//        return maxLen;
//    }
//}
#endregion


#region 169. Majority Element
/*
Example 1:
Input: nums = [3,2,3]
Output: 3

Example 2:
Input: nums = [2,2,1,1,1,2,2]
Output: 2
 
*/

//public static class Solution
//{
//    public static int MajorityElement(int[] nums)
//    {
//        Dictionary<int, int> dict = [];
//        foreach (var d in nums)
//            dict[d] = dict.GetValueOrDefault(d) + 1;


//        int maxValue = dict.Values.Max();
//        return dict.First(k => k.Value == maxValue).Key;
//    }
//}
#endregion


#region 238. Product of Array Except Self
/*
Example 1:

Input: nums = [1, 2, 3, 4]
Output: [24, 12, 8, 6]
Example 2:

Input: nums = [-1, 1, 0, -3, 3]
Output: [0, 0, 9, 0, 0]
*/
// without using the division operation ???
//public static class Solution
//{
//    public static int[] ProductExceptSelf(int[] nums)
//    {
//        int len = nums.Length;
//        int[] prefix = new int[len];
//        //int[] prefix = [len];  // error

//        prefix[0] = 1;
//        for (int i = 1; i < len; i++)
//        {
//            prefix[i] = prefix[i - 1] * nums[i - 1];
//        }

//        int suffix = 1;
//        for (int i = len - 1; i >= 0; i--)
//        {
//            prefix[i] *= suffix;
//            suffix *= nums[i];
//        }
//        return prefix;
//    }
//}

#endregion


#region 3. Longest Substring Without Repeating Characters
/*
 Example 1:
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.

Example 2:
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.

Example 3:
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 */
//public static class Solution
//{
//    public static int LengthOfLongestSubstring(string s) // "abcabcbb" // pwwkew
//    {
//        HashSet<char> hash = new HashSet<char>();
//        int start = 0, maxLen = 0;
//        for (int i = 0; i < s.Length; i++)
//        {
//            while (hash.Contains(s[i]))
//            {
//                hash.Remove(s[start]);
//                start++;
//            }

//            hash.Add(s[i]);
//            maxLen = Math.Max(maxLen, i - start + 1);
//        }
//        return maxLen;
//    }
//}
#endregion