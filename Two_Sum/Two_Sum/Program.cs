/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
/// </summary>

public class Solution
{
    public int[] TwoSum(int[]? nums, int target)
    {
        if(nums == null)
        {
            throw new ArgumentNullException("Input array is empty.");
        }
        if(nums.Length < 2)
        {
            throw new ArgumentException($"Array is too short {nums.Length}.");
        }
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { -1, -1 }; // Because of Problem constraints should not be possible
    }

    public static void Main()
    {
    }
}


