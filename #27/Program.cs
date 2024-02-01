// Problem #27

int[] nums = {1, 3, 4, 5, 6, 3, 4, 5};
int output = RemoveElement(nums, 3);

static int RemoveElement(int[] nums, int val)
{
    int k = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == val) {
            nums[i] = -22; // modifies occurence of the num val to be -22
        }
        else {
            k++; // keeping track of each number in the array that is not equal to val
        }
    }
    Array.Sort(nums); // to move all of the -22 at the begging
    Array.Reverse(nums); // to move all of the -22 at the end of the array
    return k;
}
