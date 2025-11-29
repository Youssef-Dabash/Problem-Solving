
#region 1480. Running Sum of 1d Array
//Example 1:
//Input: nums = [1, 2, 3, 4]
//Output: [1, 3, 6, 10]
//Explanation: Running sum is obtained as follows: [1, 1 + 2, 1 + 2 + 3, 1 + 2 + 3 + 4].

//Example 2:
//Input: nums = [1, 1, 1, 1, 1]
//Output: [1, 2, 3, 4, 5]
//Explanation: Running sum is obtained as follows: [1, 1 + 1, 1 + 1 + 1, 1 + 1 + 1 + 1, 1 + 1 + 1 + 1 + 1].

//Example 3:
//Input: nums = [3, 1, 2, 10, 1]
//Output: [3, 4, 6, 16, 17]

//public class SolutionWeek05 // [1, 2, 3, 4]
//{
//    public int[] RunningSum(int[] nums) // 1 3 6 10 
//    {
//        for (int i = 1; i < nums.Length; i++)
//        {
//            nums[i] = nums[i] + nums[i - 1];
//        }
//        return nums;
//    }
//}
#endregion

#region 1929. Concatenation of Array
//Example 1:
//Input: nums = [1, 2, 1]
//Output: [1, 2, 1, 1, 2, 1]
//Explanation: The array ans is formed as follows:
//- ans = [nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]
//- ans = [1, 2, 1, 1, 2, 1]

//Example 2:
//Input: nums = [1, 3, 2, 1]
//Output: [1, 3, 2, 1, 1, 3, 2, 1]
//Explanation: The array ans is formed as follows:
//- ans = [nums[0],nums[1],nums[2],nums[3],nums[0],nums[1],nums[2],nums[3]]
//- ans = [1, 3, 2, 1, 1, 3, 2, 1]

//public class SolutionWeek05
//{
//    public int[] GetConcatenation(int[] nums) // [1, 2, 1]
//    {
//        int[] ans = new int[nums.Length * 2];

//        for (int i = 0; i < nums.Length; i++) // 1 2 1 1 2 1
//        {
//            ans[i] = ans[nums.Length + i] = nums[i];
//        }
//        return ans;
//    }
//}
#endregion

#region 66. Plus One
//Example 1:
//Input: digits = [1, 2, 3]
//Output: [1, 2, 4]
//Explanation: The array represents the integer 123.
//Incrementing by one gives 123 + 1 = 124.
//Thus, the result should be[1, 2, 4].

//Example 2:
//Input: digits = [4, 3, 2, 1]
//Output: [4, 3, 2, 2]
//Explanation: The array represents the integer 4321.
//Incrementing by one gives 4321 + 1 = 4322.
//Thus, the result should be[4, 3, 2, 2].

//Example 3:
//Input: digits = [9]
//Output: [1, 0]
//Explanation: The array represents the integer 9.
//Incrementing by one gives 9 + 1 = 10.
//Thus, the result should be[1, 0].

//public class SolutionWeek05
//{
//    public int[] PlusOne(int[] digits) // 9
//    {
//        int last = digits.Length - 1;
//        for (int i = last; i >= 0; i--) // 0
//        {
//            if (digits[i] != 9)
//            {
//                digits[i]++;
//                return digits;
//            }
//            digits[i] = 0;
//        }

//        int[] newDigits = new int[last + 2]; // 1 0 
//        newDigits[0] = 1;
//        return newDigits;
//    }
//}
#endregion

#region 217. Contains Duplicate
//Example 1:
//Input: nums = [1, 2, 3, 1]
//Output: true
//Explanation:
//The element 1 occurs at the indices 0 and 3.

//Example 2:
//Input: nums = [1, 2, 3, 4]
//Output: false
//Explanation:
//All elements are distinct.

//Example 3:
//Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
//Output: true

//public class SolutionWeek05
//{
//    public bool ContainsDuplicate(int[] nums) // 1 2 3 1
//    {
//        Dictionary<int, int> res = new();

//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (!res.ContainsKey(nums[i]))
//                res.Add(nums[i], 1); 
//            else                     
//                res[nums[i]]++;      
//        }

//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (res[nums[i]] > 1)
//                return true;
//        }
//        return false;
//    }
//}
#endregion

#region 344. Reverse String
//Example 1:
//Input: s = ["h", "e", "l", "l", "o"]
//Output: ["o", "l", "l", "e", "h"]

//Example 2:
//Input: s = ["H", "a", "n", "n", "a", "h"]
//Output: ["h", "a", "n", "n", "a", "H"]

//public class SolutionWeek05
//{
//    public void ReverseString(char[] s)
//    {
//        Array.Reverse(s);

//        //char[] res = new char[s.Length];
//        //int k = 0;
//        //for (int i = s.Length - 1; i >= 0; i--)
//        //{
//        //    res[i] = s[k++];
//        //}

//        //for (int i = 0; i < s.Length; i++)
//        //{
//        //    s[i] = res[i];
//        //}

//        foreach (var item in s)
//        {
//            Console.Write(item + " ");
//        }
//    }
//}

#endregion

