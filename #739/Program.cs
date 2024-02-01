// #739

int[] temperatures = {30, 60, 90};
int[] output = DailyTemperatures(temperatures);

static int[] DailyTemperatures(int[] temperatures) 
{
    int[] outputArr = new int[temperatures.Length]; // here we store the number of days we need to wait
    int currTemp;
    for (int i = 0; i < temperatures.Length; i++) {
        currTemp = temperatures[i]; // saves the temperature that we are working with inside the currTemp variable
        // for each current temperature, we are looking for the larger value
        for (int j = i + 1; j < temperatures.Length; j ++) {
            if (temperatures[j] > currTemp) { // checking if the next values are larger then our current one
                outputArr[i] = j - i; // the difference between the index of the larger value and our current temp is the number of days we need to wait
                break; // stops checking for greater values
            }
        }
    }
    return outputArr;
}


