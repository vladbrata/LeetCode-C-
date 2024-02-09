/* #35
Given a sorted array of distinct integers and a target value, 
return the index if the target is found. If not, return the 
index where it would be if it were inserted in order.
*/
int[] nums = {1,3,5,6};
int output = SearchInsert(nums, 5);

static int SearchInsert(int[] nums, int target) 
{
    // searches for the target num in the array
    for(int i = 0; i < nums.Length; i++) {
        if(nums[i] == target) {
            return i; // if the target is found, returns the index
        }
    }
    // if the target is not found, it searches for the num that is smaller than the target
    int smallest = -1; // if no other num is smaller than the target, the target should be placed first inside the array (smallest + 1 should be 0)
    for(int i = 0; i < nums.Length; i++) {
        if (nums[i] < target) smallest = i; // updates the value as we iterate trough the nums
    }
    return smallest + 1; 
}