/*
    Problem:
    Given a string s consisting of words and spaces, return the length of 
    the last word in the string.

    A word is a maximal substring consisting of non-space characters only.
*/
/*
    Tought Process:
    First, we remove the white space from the end of the string. Then, we 
    use a do while loop and we start counting the letters from the last up 
    until the first occurence of the white space. By proceeding in this manner,
    i can count the letters of the last word.
*/

string s = "   fly me   to   the moon  ";
int count = LengthOfLastWord(s);

static int LengthOfLastWord(string s) 
{
    s = s.Trim(); // removes the white space from the end
    int i = s.Length - 1;
    int count = 0;
    // goes trough each letter of the last word
    // increments the value of count; the final value of count is the number of 
    // letters of the last word
    do {
        count++;
        i--;
    } while(i >= 0 && s[i] != ' ');
        
    return count;
}