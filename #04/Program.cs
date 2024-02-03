// #04
// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

int[] nums1 = {1, 3};
int[] nums2 = {4, 5};
double median = FindMedianSortedArrays(nums1, nums2);

double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    int[] output = new int[nums1.Length + nums2.Length]; // the new array's size is equal = sum of the two arrays

    // populates the output array with the values from the first and second arrays
    for (int i = 0; i < nums1.Length; i++) {
        output[i] = nums1[i];
    }
    for (int i = nums1.Length; i < output.Length; i++) {
        int j = 0;
        output[i] = nums2[j];
        j++;
    }

    Array.Sort(output);

    bool odd = output.Length % 2 != 0;
    bool even = output.Length % 2 == 0;
    double median = 0;

    // because the array has a clear middle element
    if (odd) {
        median = output[(0 + output.Length - 1) / 2];
    }
    // because it has 2 middle elements
    else if (even) {
        int secondMedian;
        int index;
        index = (0 + output.Length - 1) / 2;
        median = output[index];
        secondMedian = output[index + 1];
        median = (median + secondMedian) / 2;
    }
    return median;
}
