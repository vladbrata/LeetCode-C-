// #01

int[] nums = {2, 7, 11, 15};
int[] output = TwoSum(nums, 13);

static int[] TwoSum(int[] arr, int targetNum) 
{
    int[] vector = new int[2];
    // checks if the sum of each number combination is equal to targetNum
    for (int i = 0; i < arr.Length; i++) {
        for (int j = i + 1; j < arr.Length; j++) {
            if (arr[i] + arr[j] == targetNum) {
                vector[0] = i;
                vector[1] = j;
            }
        }
    }
    return arr;
}