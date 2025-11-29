
#region 1768. Merge Strings Alternately
/*
 Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s
Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d
 
 */


//using System.Text;

//public static class Solution // word1 = "abq", word2 = "pqr"
//{
//    public static string MergeAlternately(string word1, string word2)
//    {
//        int lenW1 = word1.Length;
//        int lenW2 = word2.Length;
//        StringBuilder res = new();
//        int i = 0, j = 0;
//        while (lenW1 != i || lenW2 != j)
//        {
//            if (lenW1 != i)
//                res.Append(word1[i++]);
//            if (lenW2 != j)
//                res.Append(word2[j++]);
//        }
//        return res.ToString();
//    }
//}
#endregion



#region 1071. Greatest Common Divisor of Strings
/*
 Example 1:

Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"
Example 2:

Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"
Example 3:

Input: str1 = "LEET", str2 = "CODE"
Output: ""
 
 */


//public static class Solution
//{
//    public static string GcdOfStrings(string str1, string str2) // ABCABC // ABC
//    {
//        if (str1 + str2 != str2 + str1) return ""; 

//        int lenStr1 = str1.Length; // 6
//        int lenStr2 = str2.Length; // 3

//        while (lenStr2 != 0) // 0
//        {
//            int temp = lenStr2;           // 3
//            lenStr2 = lenStr1 % lenStr2;  // 0
//            lenStr1 = temp;               // 3
//        }

//        return str1[..lenStr1];
//        //return str1.Substring(0, lenStr1);
//    }
//}
#endregion



#region 1431. Kids With the Greatest Number of Candies
/*
Example 1:

Input: candies = [2,3,5,1,3], extraCandies = 3
Output: [true,true,true,false,true] 
Example 2:

Input: candies = [4,2,1,1,2], extraCandies = 1
Output: [true,false,false,false,false] 
Explanation: There is only 1 extra candy.
Kid 1 will always have the greatest number of candies, even if a different kid is given the extra candy.
Example 3:

Input: candies = [12,1,12], extraCandies = 10
Output: [true,false,true]
 
 
 */


//public static class Solution
//{
//    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
//    {
//        List<bool> res = new();
//        int maxCande = candies.Max();
//        for (int i = 0; i < candies.Length; i++)
//        {
//            if (candies[i] + extraCandies >= maxCande)
//                res.Add(true);
//            else
//                res.Add(false);
//        }
//        return res;
//    }
//}
#endregion



#region 605. Can Place Flowers
/*
Example 1:

Input: flowerbed = [0,0,1,0,0,0,1,0,0], n = 1 
Output: true
Example 2:

Input: flowerbed = [1,0,0,0,1], n = 2
Output: false
 
 */
//public static class Solution
//{
//    public static bool CanPlaceFlowers(int[] flowerbed, int n) // [1,0,1,0,1,0,1,0,0]
//    {
//        int lenFlowerBed = flowerbed.Length;
//        for (int i = 0; i < flowerbed.Length && n > 0; i++)
//        {
//            if (flowerbed[i] == 0)
//            {
//                int perv = (i == 0) ? 0 : flowerbed[i - 1];// 0
//                int next = (i == lenFlowerBed - 1) ? 0 : flowerbed[i + 1]; // 0
//                if (perv == 0 && next == 0)
//                {
//                    flowerbed[i] = 1;
//                    n--;
//                }
//            }
//        }
//        return n == 0;
//    }
//}
#endregion



#region 345. Reverse Vowels of a Stringly
/*
Example 1:

Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

Example 2:

Input: s = "leetcode"

Output: "leotcede"
 
 */


//using System.Text;

//public static class Solution
//{
//    public static string ReverseVowels(string s) // A c e C r e I m
//    {
//        StringBuilder res = new(s);
//        int start = 0, end = s.Length - 1;
//        string vowels = "aeiouAEIOU";
//        while (start < end)
//        {
//            if (!vowels.Contains(s[start])) start++; // I e
//            else if (!vowels.Contains(s[end])) end--; // A e
//            else
//            {
//                res.Replace(s[start], s[end], start, 1);
//                res.Replace(s[end], s[start], end, 1);
//                start++;
//                end--;
//            }
//        }
//        return res.ToString();
//    }
//}
#endregion

