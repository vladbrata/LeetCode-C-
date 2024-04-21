/*
    Problem:
    Given an integer array nums and an integer k, return the kth 
    largest element in the array.

    Note that it is the kth largest element in the sorted order, 
    not the kth distinct element.
    Can you solve it without sorting?
*/
/*
    Tought Process:
    First of all, we sort the array. The largest element is the last 
    element a sorted Array. That means, the kth largest is the kth element
    from right to left.
*/

int[] nums = {3,2,1,5,6,4};
int k = 2;
int kthLargest = FindKthLargest(nums, k);
Console.WriteLine(kthLargest);

static int FindKthLargest(int[] nums, int k)
{
    Array.Sort(nums);
    return nums[nums.Length - k];
} 