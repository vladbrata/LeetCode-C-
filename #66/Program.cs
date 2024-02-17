/*
    Problem:
    You are given a large integer represented as an integer array digits, where each digits[i] 
    is the ith digit of the integer. The digits are ordered from most significant to least significant 
    in left-to-right order. The large integer does not contain any leading 0's.

    Increment the large integer by one and return the resulting array of digits
*/
/*
    Tought Process:
    In case it's necessary to add more numbers to the array, we create a copy of the input array, but reversed 
    (since the .Resize() method) inserts a new number at the end of the array.
    We operate on the nums inside the array as if they were a whole number. We add one to the number. If by adding 
    one we reach ten, then we write 0 and carry the one. If the number overflows, we insert a new element in the array. 
    After the addition is done, we reverse the array back to the required order.
*/
int[] nums = {9,9};
int[] output = PlusOne(nums);

static int[] PlusOne(int[] digits) 
{
    // creating a mirrored copy of input array
    int[] newArr = new int[digits.Length];
    Array.Copy(digits, newArr, digits.Length);
    Array.Reverse(newArr);

    // performs the addition
    // if the digit + 1 > 9, we write 0 and carry the one
    // if overflows, then insert new element
    // repeat until the addition is complete
    for(int i = 0; i < newArr.Length; i++) {
        if (i == newArr.Length - 1 && newArr[i] == 9) {
            Array.Resize(ref newArr, newArr.Length + 1);
            newArr[i] = 0;
        }
        else if (newArr[i] == 9) {
            newArr[i] = 0;
        }
        else {
            newArr[i] += 1;
            break;
        }
    }
    // when done, reverse the array back to it's original order
    Array.Reverse(newArr);
    return newArr;
}