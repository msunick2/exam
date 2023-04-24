string[] makeArrayWithThreeDigits(string[] array) {
    int count = 0;
    for(int i = 0; i < array.Length; i++) {
       if (array[i].Length <= 3) {
            count++;
       }
    }
 }
    string[] newArray = new string[count];
    if (count > 0) {
        int j = 0;
        for(int i = 0; i < array.Length; i++) {
            if (array[i].Length <= 3) {
                newArray[j] = array[i];
                j++;
            }
        }   
    }
    return newArray;
}
