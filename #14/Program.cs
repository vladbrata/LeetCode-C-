/*
    Problem:
    Write a function to find the longest common prefix string 
    amongst an array of strings.

    f there is no common prefix, return an empty string "".
*/
/*
    Tought Process:
    We take the first letter from the first word. We check if
    the rest of words have that exact first letter. If every 
    word has it, we go on to the next one. We do that until we
    encounter a letter that does not match the others.
*/

string[] strs = {"cir","car"};
string output = LongestCommonPrefix(strs);
Console.WriteLine(output);

static string LongestCommonPrefix(string[] strs)
{
    string firstStr = strs[0];
        string output = "";
        int j = 0;
        // we check every words' first letter. if they match, we go on to the next
        for (int i = 0; i < firstStr.Length; i++) {
            char currLetter = firstStr[i];
            int count = 0;
            bool found = true;
            foreach (string str in strs) {
                if (j >= str.Length) break;
                else if (str[j] == currLetter) {
                    count++;
                }
                else {
                    found = false; 
                    break;
                }
                if (count == strs.Length) output += currLetter;
                
            }            
            //if every word inside the array containts currLetter, we save it to the output variable
            if (!found) break;
            j++;
        }
    return output;
}