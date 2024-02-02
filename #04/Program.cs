// #04
// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

int[] nums1 = {1, 3};
int[] nums2 = {4, 5};
double median = FindMedianSortedArrays(nums1, nums2);

double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    int[] output = new int[nums1.Length + nums2.Length];

    for (int i = 0; i < nums1.Length; i++) {
        output[i] = nums1[i];
    }
    int cnt = 0;
    for (int i = nums1.Length; i < output.Length; i++) {
        output[i] = nums2[cnt];
        cnt++;
    }

    Array.Sort(output);

    bool impar = output.Length % 2 != 0;
    bool par = output.Length % 2 == 0;
    double median = 0;
    double secondMedian = 0;
    int index = 0;

    if (impar) {
        median = output[(0 + output.Length - 1) / 2];
    }
    else if (par) {
        index = (0 + output.Length - 1) / 2;
        median = output[index];
        secondMedian = output[index + 1];
        median = (median + secondMedian) / 2;
    }
    return median;
}
