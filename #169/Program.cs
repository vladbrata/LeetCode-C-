/* #169
    Given an array nums of size n, return the majority element.

    The majority element is the element that appears more than ⌊n / 2⌋ times. 
    You may assume that the majority element always exists in the array.
*/
int[] nums = {3,3,4};
int output = MajorityElement(nums);

static int MajorityElement(int[] nums) 
{
    int contender = 0;
    int count;

    for(int i = 0; i < nums.Length; i++) {
        count = 0;
        contender = nums[i];
        for(int j = 0; j < nums.Length; j++) {
            if (contender == nums[j]) count++;
        }
        if (count > nums.Length /2) {
            return contender;
        } 
    }
    return contender;
}