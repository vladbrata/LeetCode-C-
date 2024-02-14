/* #80
    Problem: 
    Given an integer array nums sorted in non-decreasing order, remove some duplicates in-place 
    such that each unique element appears at most twice. The relative order of the elements should be kept the same.

    Since it is impossible to change the length of the array in some languages, you must instead 
    have the result be placed in the first part of the array nums. More formally, if there are 
    k elements after removing the duplicates, then the first k elements of nums should hold the 
    final result. It does not matter what you leave beyond the first k elements.

    Return k after placing the final result in the first k slots of nums.
*/
/*
    Tought Process: 
    We take each number inside of the array. We check it's frequency. If the number appears more than 2 times,
    we modify those numbers so they are unlikely to appear inside of the array.

    After we modified them, we sort the array so taht the modified numbers end up at the end. Afterwards,we iterate trough each
    element inside the array so that we can count the unique ones.
*/
int[] nums = {0,0,1,1,1,1,2,2,2,4};
int output = RemoveDuplicates(nums);


static int RemoveDuplicates(int[] nums) 
{
    int contender = 0;
    int cnt;
    int k = 0;
    // the outer loop is picking and running verification on each num of the array
    for(int i = 0; i < nums.Length; i++) {
        contender = nums[i]; // the number that we are currently verifying
        cnt = 0;
        // the inner loop is checking how many times the current num is appearing 
        for (int j = 0; j < nums.Length; j++) {
            // if the contender appears more than 2 times, we modify every appearence after the second one
            if (cnt >= 2 && contender == nums[j]) {
                nums[j] = 1410234013;
                break;
            }
            else if (contender == nums[j]) cnt++;        
        }
    }
    // counting how many numbers are not duplicates
    for (int i = 0; i < nums.Length; i++) {
        if (nums[i] != 1410234013) k++;
    }

    Array.Sort(nums);
    return k;
}