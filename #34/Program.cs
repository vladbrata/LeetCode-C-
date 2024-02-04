// #34
// Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

// If target is not found in the array, return [-1, -1].

// You must write an algorithm with O(log n) runtime complexity.


 static int[] SearchRange(int[] nums, int target) 
 {
    int[] output = {-1, -1}; // default value is unfound. the following code modifies this array if value is found
    // the outter for loop
    // goes trough each element of the array
    for (int i = 0; i < nums.Length; i++) {
        // in the first run of the outter for loop, the inner while loop iterates trough
        // the array backwards in order, until the last position is found, so we can find
        // both first and last positions in just one iteration
        int j = nums.Length - 1;
        bool found = false;
        do {
            if (nums[j] == target) {
                output[1] = j;
                found = true;
                break;
            }
            j--;
        } while (j >= 0 && !found);
        // after the last position is found, the outter for loop continues its search for the first position
        if (nums[i] == target) {
            output[0] = i;
            break;
        }
    }
    return output;
}