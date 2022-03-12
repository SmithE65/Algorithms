namespace Alg.Net;

public static class LeetCode
{
    /// <summary>
    /// 1. Two Sum
    /// Given an array of integers nums and an integer target,
    /// return indices of the two numbers such that they add up to target.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] TwoSum(int[] nums, int target)
    {
        // Brute force
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        throw new ArgumentException("target cannot be reached with provided nums");
    }

    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers.
    /// The digits are stored in reverse order, and each of their nodes contains a single digit.
    /// Add the two numbers and return the sum as a linked list.
    /// </summary>
    /// <param name="l1"></param>
    /// <param name="l2"></param>
    /// <returns></returns>
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return ToListNode(ToInt(l1) + ToInt(l2));

        static int ToInt(ListNode? listNode)
        {
            int i = 1;
            int result = 0;

            while (listNode != null)
            {
                result += listNode.val * i;
                i *= 10;
                listNode = listNode?.next;
            }

            return result;
        }

        static ListNode ToListNode(int i)
        {
            var array = i.ToString().Select(x => int.Parse(x.ToString())).Reverse().ToArray();

            var root = new ListNode() { val = array[0] };
            var next = root;

            for (int j = 1; j < array.Length; j++)
            {
                next.next = new ListNode { val = array[j] };
                next = next.next;
            }

            return root;
        }
    }

    /// <summary>
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length < 2)
        {
            return s.Length;
        }

        int i;
        var h = new HashSet<char>();

        for (i = 0; i < s.Length; i++)
        {
            if (h.Contains(s[i]))
            {
                break;
            }

            h.Add(s[i]);
        }

        var j = LengthOfLongestSubstring(s[1..]);
        return i > j ? i : j;
    }

    /// <summary>
    /// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <returns></returns>
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var merged = new int[nums1.Length + nums2.Length];
        int j = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            while (j < nums2.Length && nums2[j] < nums1[i])
            {
                merged[i + j] = nums2[j++];
            }
            merged[i + j] = nums1[i];
        }
        for (; j < nums2.Length; j++)
        {
            merged[nums1.Length + j] = nums2[j];
        }

        if (merged.Length % 2 == 0)
        {
            var half = merged.Length / 2;
            return (merged[half] + merged[half - 1]) / 2d;
        }

        return merged[merged.Length / 2];
    }
}

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}
