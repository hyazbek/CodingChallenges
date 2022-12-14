// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using static CodingChallenges.Level1;
using CodingChallenges;

Console.WriteLine("LEETCODE CODING CHALLENGES");
Console.WriteLine("__________________________");

Console.WriteLine("\n\n1480. Running Sum of 1d Array");
Console.WriteLine("*****************************");
Console.WriteLine(Level1.RunningSum(new int[] { 1, 5, 2, 6, 7, 4 }));

Console.WriteLine("\n724.Find Pivot Index");
Console.WriteLine("********************");
Console.WriteLine(Level1.PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 }));

Console.WriteLine("\n205.Isomorphic Strings");
Console.WriteLine("**********************");
Console.WriteLine(Level1.IsIsomorphic("bbbaaaba", "aaabbbba"));

Console.WriteLine("\n392. Is Subsequence");
Console.WriteLine("**********************");
Console.WriteLine(Level1.IsSubsequence("ab", "baab"));

Console.WriteLine("\n21.Merge Two Sorted Lists");
Console.WriteLine("***************************");

Console.WriteLine("\n206. Reverse Linked List");
Console.WriteLine("**************************");

Console.WriteLine("\n876.Middle of the Linked List");
Console.WriteLine("*******************************");
Level1.MiddleNode(new Level1.ListNode(0, null));

Console.WriteLine("\n142.Linked List Cycle II");
Console.WriteLine("**************************");

Console.WriteLine("\n121.Best Time to Buy and Sell Stock");
Console.WriteLine("*************************************");
Console.WriteLine(Level1.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));

Console.WriteLine("\n409.Longest Palindrome");
Console.WriteLine("************************");
Console.WriteLine(Level1.LongestPalindrome("abccccdd"));

Console.WriteLine("\n589.N - ary Tree Preorder Traversal");
Console.WriteLine("*************************************");

Console.WriteLine("\n102.Binary Tree Level Order Traversal");
Console.WriteLine("***************************************");

Console.WriteLine("\n704.Binary Search");
Console.WriteLine("*******************");
Console.WriteLine(Level1.BinarySearch(new[] { -1, 0, 3, 5, 9, 12 }, 9));

Console.WriteLine("\n704.Binary Search Recursive");
Console.WriteLine("*******************");
Console.WriteLine(Level1.BinarySearchRecursive(new[] { -1, 0, 3, 5, 9, 12 }, 9));

Console.WriteLine("\n278. First Bad Version");
Console.WriteLine("*******************");
Console.WriteLine(Level1.FirstBadVersion(5));

Console.WriteLine("\n98. Validate Binary Search Tree");
Console.WriteLine("*********************************");

Console.WriteLine("\n733. Flood Fill");
Console.WriteLine("*****************");

Console.WriteLine("\n200. Number of Islands");
Console.WriteLine("************************");

Console.WriteLine("\n977.Squares of a Sorted Array");
Console.WriteLine("*******************************");
Console.WriteLine(AlgorithmI.SortedSquares(new int[] { -4, -1, 0, 3, 10 }));

Console.WriteLine("\n189. Rotate Array");
Console.WriteLine("*******************");

Console.WriteLine("\nSort People");
Console.WriteLine("*************");
AlgorithmI.SortPeople(new string[] { "Mary", "John", "Emma" }, new int[] { 180, 165, 170 });

Console.WriteLine("\n438. Find All Anagrams in a String");
Console.WriteLine("************************************");
Console.WriteLine(Level1.FindAnagrams("cbaebabacd", "abc"));

Console.WriteLine("\n424. Longest Repeating Character Replacement");
Console.WriteLine("**********************************************");
Console.WriteLine(Level1.CharacterReplacement("AABABBA", 1));

Console.WriteLine("\n1. Two Sum");
Console.WriteLine("************");
Console.WriteLine(Level1.TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11));

Console.WriteLine("\n283. Move Zeroes");
Console.WriteLine("******************");
AlgorithmI.MoveZeroes(new int[] { 1, 0, 1 });

Console.WriteLine("\n167.Two Sum II - Input Array Is Sorted");
Console.WriteLine("****************************************");
AlgorithmI.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

Console.WriteLine("\n344. Reverse String");
Console.WriteLine("*********************");
AlgorithmI.ReverseString("hello".ToCharArray());

Console.WriteLine("\n557. Reverse Words in a String III");
Console.WriteLine("************************************");
Console.WriteLine(AlgorithmI.ReverseWords("Let's take LeetCode contest"));

Console.WriteLine("\n876. Middle of the Linked List");
Console.WriteLine("********************************");

Console.WriteLine("\n19.Remove Nth Node From End of List");
Console.WriteLine("********************************");

Console.WriteLine("\n3. Longest Substring Without Repeating Characters");
Console.WriteLine("***************************************************");
Console.WriteLine(AlgorithmI.LengthOfLongestSubstring("pwwkew"));

Console.WriteLine("\n567.Permutation in String");
Console.WriteLine("***************************");
AlgorithmI.CheckInclusion("adc", "dcda");

Console.WriteLine("\n299. Bulls and Cows");
Console.WriteLine("***************************");
Console.WriteLine(Level1.GetHint("1807", "7810"));

Console.WriteLine("\n844.Backspace String Compare");
Console.WriteLine("***************************");
Level1.BackspaceCompare("abcd", "bbcd");

Console.WriteLine("\n394. Decode String");
Console.WriteLine("*********************");
Level1.DecodeString("3[a2[c]]");

Console.WriteLine("\n1046. Last Stone Weight");
Console.WriteLine("*************************");
Console.WriteLine(Level1.LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 }));

Console.WriteLine("\n692.Top K Frequent Words");
Console.WriteLine("**************************");
Level1.TopKFrequent(new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 2);

Console.WriteLine("\n733. Flood Fill");
Console.WriteLine("*****************");

Console.WriteLine("\n695. Max Area of Island");
Console.WriteLine("*****************");
int[][] arr = new int[8][];
arr[0] = new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 };
arr[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 };
arr[2] = new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
arr[3] = new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 };
arr[4] = new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 };
arr[5] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
arr[6] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 };
arr[7] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 };
Console.WriteLine(AlgorithmI.MaxAreaOfIsland(arr));

Console.WriteLine("\n617.Merge Two Binary Trees");
Console.WriteLine("*****************");

Console.WriteLine("\n202. Happy Number");
Console.WriteLine("*******************");
Level2.IsHappy(7);

Console.WriteLine("\n14. Longest Common Prefix");
Console.WriteLine("***************************");
Level2.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });

Console.WriteLine("\n43. Multiply Strings");
Console.WriteLine("**********************");
Console.WriteLine(Level2.Multiply("123456789", "987654321"));

Console.WriteLine("\n328.Odd Even Linked List");
Console.WriteLine("**********************");

Console.WriteLine("\n110.Balanced Binary Tree");
Console.WriteLine("**********************");

Blind75 b = new Blind75();
b.MaxProduct(new int[] { -2, 3, -4 });
b.Search(new int[] { 3, 1 }, 3);
b.ThreeSum(new int[] { -3, 1, 2, 3, -3, 4 });
b.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });

ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
b.ReverseList(head);

ListNode reorder = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
b.ReorderList(reorder);

int[][] matrix = new int[3][];
matrix[0] = new int[] { 0, 1, 2, 0 };
matrix[1] = new int[] { 3, 4, 5, 2 };
matrix[2] = new int[] { 1, 3, 1, 5 };
b.SetZeroes(matrix);

int[][] spiral = new int[3][];
spiral[0] = new int[] { 1, 2, 3, 4 };
spiral[1] = new int[] { 5, 6, 7, 8 };
spiral[2] = new int[] { 9, 10, 11, 12 };
b.SpiralOrder(spiral);

int[][] rotateImage = new int[4][];
rotateImage[0] = new int[] { 1, 2, 3, 4 };
rotateImage[1] = new int[] { 4, 5, 6, 5 };
rotateImage[2] = new int[] { 7, 8, 9, 6 };
rotateImage[3] = new int[] { 6, 5, 4, 3 };
b.Rotate(rotateImage);

char[][] wordSearch = new char[3][];
wordSearch[0] = new char[] { 'a', 'b', 'c', 'e' };
wordSearch[1] = new char[] { 's', 'f', 'c', 's' };
wordSearch[2] = new char[] { 'a', 'd', 'e', 'e' };
b.Exist(wordSearch, "abcced");

b.CharacterReplacement("AABABBA", 1);

b.MinWindow("ADOBECODEBANC", "AABC");

DSACourse_UnionFind uf = new DSACourse_UnionFind(10);

StackUsingArray<string> stack = new(4);
stack.Push("str 1");
stack.Push("str 2");
Console.WriteLine($"Stack using Array: {stack.Pop()}");
stack.Push("str 3");
stack.Push("str 4");
Console.WriteLine($"Stack using Array: {stack.Pop()}");

Console.WriteLine(DsaCourseWeek2.ArithmeticEvaluation("(1+((2+3)*(4*5)))"));

DsaCourseWeek2.ShellSort(new int[] { 2, 1, 7, 54, 9, 3, 6, 2, 0, 9, 33, 2 });

int[] merge = new int[] { 7, 11, 88, 99, 1, 6, 9, 22, 55 };
int mid = merge.Length / 2;
DsaCourseWeek3.MergeSort(merge, 0, mid, arr.Length - 1);

int[] quickSort = new int[] { 90, 86, 5, 97, 16, 66, 48, 61, 78 };
int[] sorted = new int[quickSort.Length];
sorted = DsaCourseWeek3.QuickSort(quickSort, 0, quickSort.Length - 1);
Console.WriteLine("sorted");
Console.Clear();

LcEasy.TwoSum(new int[] { 2, 2, 7, 11, 15 }, 9);
LcEasy.IsValidParentheses("(])");

ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
LcEasy.MergeTwoLists(list1, list2);

LcEasy.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);

LcEasy.Generate(5);

LcEasy.SingleNumber(new int[] { 2, 2, 1 });

LcEasy.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });

LcEasy.LengthOfLongestSubstring("aab");

LcEasy.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });

LcEasy.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

LcEasy.TwoSumII(new int[] { 2, 7, 11, 15 }, 9);

LcEasy.SwapPairs(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));

int[][] fall = new int[3][];
fall[0] = new int[] { 2, 1, 3 };
fall[1] = new int[] { 6, 5, 4 };
fall[2] = new int[] { 7, 8, 9 };
LcEasy.MinFallingPathSum(fall);

LcEasy.Rob(new int[] { 2, 7, 9, 3, 1 });