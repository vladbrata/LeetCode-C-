// #88
/* You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, 
and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function
but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, 
where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and 
should be ignored. nums2 has a length of n.
*/

int[] nums1 = {1,2,3,0,0,0};
int[] nums2 = {2,5,6};

int m = 3;
int n = 3;

static void Merge(int[] nums1, int m, int[] nums2, int n) 
{
    Array.Resize(ref nums1, m + n);
    // fills the empty spots inside nums1 with the integers from nums2
    int j = 0;
    for(int i = m; i < nums1.Length; i++) {
        while (j < nums1.Length) {
            nums1[i] = nums2[j];
            j++;
            break;
        }
    }
    Array.Sort(nums1);
}
Merge(nums1, m, nums2, n);