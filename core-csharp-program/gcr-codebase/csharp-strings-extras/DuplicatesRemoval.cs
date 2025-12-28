using System;

class DuplicatesRemoval{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        string result = "";

        for (int i = 0; i < str.Length; i++){
            bool found = false;
            for (int j = 0; j < result.Length; j++){
                if (str[i] == result[j]){
                    found = true;
                    break;
                }
            }
            if (!found)    result += str[i];
        }
        Console.WriteLine("After removing duplicates: " + result);
    }
}
