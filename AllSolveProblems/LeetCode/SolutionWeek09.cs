

#region 151. Reverse Words in a String
/*
 Example 1:

Input: s = "the sky is blue"
Output: "blue is sky the"
Example 2:

Input: s = "  hello world  "
Output: "world hello"
Example 3:

Input: s = "a good   example"
Output: "example good a"
 */

using System.Text;

public static class Solution
{
    public static string ReverseWords(string s)
    {
        var arrS = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new();
        for (int i = arrS.Length - 1; i >= 0; i--)
        {
            sb.Append(arrS[i]).Append(' ');
        }
        return sb.ToString();
    }
}
#endregion

#region 238. Product of Array Except Self
/*
Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
 
 */

//public static class Solution
//{
//    public static int[] ProductExceptSelf(int[] nums) // 1,2,3,4
//    {
//        int len = nums.Length;
//        int[] prefex = new int[len];

//        prefex[0] = 1;
//        for (int i = 1; i < len; i++) 
//        {
//            prefex[i] = prefex[i - 1] * nums[i - 1]; // 1 1 2 6
//        }

//        int suffix = 1;
//        for (int i = len - 1; i >= 0; i--) // 1 1 2 6
//        {
//            prefex[i] *= suffix; // 24 12 8 6
//            suffix *= nums[i];   // 24 12 4 1 
//        }

//        return prefex;
//    }
//}
#endregion