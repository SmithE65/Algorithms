using Xunit;

namespace Alg.Net.Tests;

public class LeetCodeTests
{

    #region TwoSort

    [Fact]
    public void TwoSortEx1()
    {
        // Arrange
        var nums = new int[] { 2, 7, 11, 15 };
        var target = 9;

        // Act
        var result = LeetCode.TwoSum(nums, target);

        // Assert
        Assert.Equal(2, result.Length);
        Assert.Equal(target, nums[result[0]] + nums[result[1]]);
    }

    [Fact]
    public void TwoSortEx2()
    {
        // Arrange
        var nums = new int[] { 3, 2, 4 };
        var target = 6;

        // Act
        var result = LeetCode.TwoSum(nums, target);

        // Assert
        Assert.Equal(2, result.Length);
        Assert.Equal(target, nums[result[0]] + nums[result[1]]);
    }

    [Fact]
    public void TwoSortEx3()
    {
        // Arrange
        var nums = new int[] { 3, 3 };
        var target = 6;

        // Act
        var result = LeetCode.TwoSum(nums, target);

        // Assert
        Assert.Equal(2, result.Length);
        Assert.Equal(target, nums[result[0]] + nums[result[1]]);
    }

    #endregion

    #region AddTwoNumbers

    [Fact]
    public void AddTwoNumbersEx1()
    {
        // Arrange
        var l1 = CreateFromArray(new int[] { 2, 4, 3 });
        var l2 = CreateFromArray(new int[] { 5, 6, 4 });

        // Act
        var result = LeetCode.AddTwoNumbers(l1, l2);

        // Assert
        var expected = CreateFromArray(new int[] { 7, 0, 8 });
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }

    [Fact]
    public void AddTwoNumbersEx2()
    {
        // Arrange
        var l1 = CreateFromArray(new int[] { 0 });
        var l2 = CreateFromArray(new int[] { 0 });

        // Act
        var result = LeetCode.AddTwoNumbers(l1, l2);

        // Assert
        var expected = CreateFromArray(new int[] { 0 });
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }

    [Fact]
    public void AddTwoNumbersEx3()
    {
        // Arrange
        var l1 = CreateFromArray(new int[] { 9, 9, 9, 9, 9, 9, 9 });
        var l2 = CreateFromArray(new int[] { 9, 9, 9, 9 });

        // Act
        var result = LeetCode.AddTwoNumbers(l1, l2);

        // Assert
        var expected = CreateFromArray(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 });
        while (expected != null)
        {
            Assert.Equal(expected.val, result.val);
            expected = expected.next;
            result = result.next;
        }
    }

    private static ListNode CreateFromArray(int[] a)
    {
        var root = new ListNode { val = a[0] };
        var next = root;

        for (int i = 1; i < a.Length; i++)
        {
            next.next = new ListNode { val = a[i] };
            next = next.next;
        }

        return root;
    }

    #endregion

    #region LengthOfLongestSubstring

    [Fact]
    public void LengthOfLongestSubstringEx1()
    {
        // Arrange
        var s = "abcabcbb";

        // Act
        var result = LeetCode.LengthOfLongestSubstring(s);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void LengthOfLongestSubstringEx2()
    {
        // Arrange
        var s = "bbbbb";

        // Act
        var result = LeetCode.LengthOfLongestSubstring(s);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void LengthOfLongestSubstringEx3()
    {
        // Arrange
        var s = "pwwkew";

        // Act
        var result = LeetCode.LengthOfLongestSubstring(s);

        // Assert
        Assert.Equal(3, result);
    }

    #endregion

}
