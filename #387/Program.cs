// #387
//Given a string s, find the first non-repeating character in it and return its index. 
// If it does not exist, return -1.

string s = "dddccdbba";
int output = FirstUniqChar(s);
Console.WriteLine(output);

static int FirstUniqChar(string s) 
{
    bool found = false;
    int pretendent = 0;
    switch (s.Length) {
        case 0:
            return -1;
        case 1:
            return 0;
        case > 1:
            // the outter loop grabs a char from the string and stores inside pretendent
            for (int i = 0; i < s.Length; i++) {
                pretendent = i;
                // the inner for loop checks if the rest of the chars in the string is equal to pretendent
                for (int j = 0; j < s.Length; j++) {
                    // if pretendent is the last char in the string, the inner for loop ends before compliting
                    // it's last iteration
                    // if up to this point no char is equal to pretendent, we have found the answer
                    if (i == s.Length - 1 && j == i - 1 && s[i] != s[j]) {
                        found = true;
                        break ;
                    }
                    if (j == i) continue; // so we don't compare the same element
                    // because pretendent should be unique
                    if (s[i] == s[j]) {
                        break;
                    }
                    // if up until the last iteration of the inner loop we haven't found an char equal
                    // to pretendent, then the pretendent is the unique char
                    else if (s[i] != s[j] && j == s.Length - 1) {
                        found = true;
                    }
                } 
                if (!found && i == s.Length - 1) return -1;
                else if (found) break;
            }
            break;
    }
    return pretendent;
}