string[] makeArrayWithThreeDigits(string[] array) {
    int count = 0;
    for(int i = 0; i < array.Length; i++) {
       if (array[i].Length <= 3) {
            count++;
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



//testing
string[] myArray1 = {"Nikky", "Nik", "Asya", "Vanya", "Van", "Ann"};
string[] myArray2 = {};
string[] myArray3 = {"31454t", "", "pojigeht"};
string[] myArray4 = {"gsf"};

Console.WriteLine(string.Join(",", makeArrayWithThreeDigits(myArray1)));
Console.WriteLine(string.Join(",", makeArrayWithThreeDigits(myArray2)));
Console.WriteLine(string.Join(",", makeArrayWithThreeDigits(myArray3)));
Console.WriteLine(string.Join(",", makeArrayWithThreeDigits(myArray4)));