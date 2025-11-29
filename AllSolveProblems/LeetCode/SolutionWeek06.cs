#region 125. Valid Palindrome
/*
Example 1:
Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:
Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.

Example 3:
Input: s = " "
Output: true
 */

//using System.Text.RegularExpressions;

//public class SolutioSolutionWeek06
//{
//    public bool IsPalindrome(string s)
//    {
//        string newS = Regex.Replace(s, @"[^A-Za-z0-9]", "").ToLower();
//        int lastS = newS.Length;
//        for (int i = 0; i < newS.Length / 2; i++)
//        {
//            if (newS[i] != newS[--lastS]) return false;
//        }
//        return true;
//    }
//}
#endregion


#region 1. Two Sum
/*
Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1] */

//public class SolutioSolutionWeek06
//{
//    public int[] TwoSum(int[] nums, int target) // 2,7,11,15  == 9
//    {
//        Dictionary<int, int> dict = [];
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (dict.ContainsKey(target - nums[i])) // 2
//                return [dict[target - nums[i]], i]; // 0,1

//            dict[nums[i]] = i;
//            //dict.Add(nums[i], i);
//            // 2  0

//        }
//        return [];

//    }
//}
#endregion


#region 58. Length of Last Word
/*
Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
Example 2:

Input: s = "   fly me   to   the moon  "
Output: 4
Explanation: The last word is "moon" with length 4.
Example 3:

Input: s = "luffy is still joyboy"
Output: 6
*/


//public class SolutioSolutionWeek06
//{
//    public int LengthOfLastWord(string s) // "   fly me   to   the moon"
//    {
//        s = s.TrimEnd();

//        int count = default;
//        for (int i = s.Length - 1; i >= 0; i--)
//        {
//            if (s[i] != ' ') count++;
//            else return count;
//        }
//        return count;
//    }
//}
#endregion


#region 242. Valid Anagram
/*
Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false
*/

//public class SolutioSolutionWeek06
//{
//    public bool IsAnagram(string s, string t) // a a a g n m r
//    {
//        if (s.Length != t.Length) return false;
//        var sArray = s.ToCharArray();
//        var tArray = t.ToCharArray();
//        Array.Sort(sArray);
//        Array.Sort(tArray);
//        for (int i = 0; i < sArray.Length; i++)
//        {
//            if (sArray[i] != tArray[i]) return false;
//        }
//        return true;
//    }
//}
#endregion


#region 121. Best Time to Buy and Sell Stock
/*
Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
*/

//public class SolutioSolutionWeek06
//{
//    public int MaxProfit(int[] prices) // 7,1,5,3,6,4
//    {
//        int max = 0;
//        int min = prices[0];
//        for (int i = 0; i < prices.Length; i++)
//        {
//            if (prices[i] < min)
//            {
//                min = prices[i];  // 7 1
//            }

//            if (prices[i] - min > max)
//            {
//                max = prices[i] - min; // 0  4 5
//            }
//        }
//        return max;



//    }
//}
#endregion

