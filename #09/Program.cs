// #09
// Given an integer x, return true if x is a palindrome, and false otherwise

int num = 121;
bool output = IsPalindrome(num);

static bool IsPalindrome(int x) 
{
    if (ReverseInt(x) == x) {
        return true;
    }
    else return false;
}
static int ReverseInt (int num) 
{
    int result = 0;
    while (num>0) 
    {
        result = result*10 + num%10;
        num /= 10;
    }
    return result;
}