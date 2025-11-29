
#region Week 01

//Solution solution = new Solution();

//solution.MoveZeroes([0, 1, 0, 3, 12]);

//WriteLine(solution.RomanToInt("MCMXCIV"));


//var res = solution.LongestCommonPrefix(["flower", "flow", "flight"]);
//WriteLine(res);


//var res = solution.TopKFrequent([1, 1, 1, 2, 2, 3], 2);
//WriteLine(string.Join(", ", res));


//var res = solution.IsValid("([{]})");
//WriteLine(res);

#endregion

#region Week 02
//SolutionWeek02 solution = new SolutionWeek02();

////ListNode head = new(1, new(2, new(3, new(4, new(5)))));  // Example 1: head = [1,2,3,4,5]
////ListNode res = solution.MiddleNode(head);


////ListNode head = new(1, new(2, new(3, new(4, new(5)))));  // Example 1: head = [1,2,3,4,5]
////ListNode res = solution.ReverseList(head);

//ListNode list1 = new(0);
//ListNode list2 = new();
//ListNode res = solution.MergeTwoLists(list1, list2);


// Print all
//while (res != null)
//{
//    Write(res.val + " ");
//    res = res.next;
//}

#endregion

#region Week 03
//SolutionWeek03 solution = new SolutionWeek03();

//ListNode head = new(3, new(2, new(0, new(-4))));
//WriteLine(solution.HasCycle(head));

//ListNode head = new(1, new(2, new(2, new(1))));
//WriteLine(solution.IsPalindrome(head));

#endregion

#region Week 04
//SolutionWeek04 solution = new SolutionWeek04();

//ListNode res = solution.RemoveElements(new(1, new(2, new(6, new(3, new(4, new(5, new(6))))))), 6);
////ListNode res = solution.RemoveElements(new(7, new(7, new(7, new(7)))), 7);
//while (res != null)
//{
//    Write(res.val + " ");
//    res = res.next;
//}


//ListNode res = solution.GetIntersectionNode(new(4, new(1, new(8, new(4, new(5))))),
//                                     new(5, new(6, new(1, new(8, new(4, new(5)))))));
//WriteLine(res);

//ListNode common = new(8, new(4, new(5)));
//ListNode headA = new(4, new(1, common));
//ListNode headB = new(5, new(6, new(1, common)));
//ListNode res = solution.GetIntersectionNode(headA, headB);
//WriteLine(res?.val);


//ListNode res3 = solution.RotateRight(new(1, new(2, new(3, new(4, new(5))))), 2);
//while (res3 != null)
//{
//    Write(res3.val + " ");
//    res3 = res3.next;
//}
#endregion

#region Week 05
// hashmap


//SolutionWeek05 s1 = new();

//var res1 = s1.RunningSum([1, 2, 3, 4]);

//var res2 = s1.GetConcatenation([1, 2, 1]);

//var res3 = s1.PlusOne([0]);

//WriteLine(s1.ContainsDuplicate([1, 2, 3, 4]));

//s1.ReverseString(['h', 'e', 'l', 'l', 'o']);

//foreach (var item in res5)
//{
//    Write(item + " ");
//}
#endregion

#region Week 06
//SolutioSolutionWeek06 solution = new();

//WriteLine(solution.IsPalindrome("a"));

//WriteLine($"[{solution.TwoSum([2, 7, 11, 15], 9)[0]}, {solution.TwoSum([2, 7, 11, 15], 9)[1]}]");

//WriteLine(solution.LengthOfLastWord("   fly me   to   the moon  "));

//WriteLine(solution.IsAnagram("anagram", "nagaram"));

//WriteLine(solution.MaxProfit([7, 6, 4, 3, 1]));



//string s = "A man, a plan, a canal: Panama";
//var match = Regex.Matches(s, "[A-Za-z]");
//WriteLine(match.ToString());
//foreach (Match m in match)
//    Console.Write(m.Value);
#endregion

#region Week 07

//WriteLine(Solution.FindLHS([1, 3, 2, 2, 5, 2, 3, 7]));

//WriteLine(Solution.MajorityElement([2, 2, 1, 1, 1, 2, 2]));

//var res = Solution.ProductExceptSelf([1, 2, 3, 4]);
//var res = Solution.ProductExceptSelf([-1, 1, 0, -3, 3]);
//foreach (var item in res) Write($"{item} ");


//WriteLine(Solution.LengthOfLongestSubstring("abcabcbb"));
//WriteLine(Solution.LengthOfLongestSubstring("pwwkew"));
#endregion

#region Week 08
//WriteLine(Solution.MergeAlternately("ac", "pqr"));

//WriteLine(Solution.GcdOfStrings("ABABAB", "ABAB"));

//var res = Solution.KidsWithCandies([2, 3, 5, 1, 3], 3);
//foreach (var r in res) WriteLine(r);

//WriteLine(Solution.CanPlaceFlowers([ 0, 1, 0, 0, 1, 0, 0], 2));

//WriteLine(Solution.ReverseVowels("IceCreAm")); // AceCreIm 
#endregion