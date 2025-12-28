using System;

class TopRepeatedCharacter{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        int[] freq = new int[256];

        for (int i = 0; i < str.Length; i++)    freq[str[i]]++;

        char result = str[0];
        int max = freq[result];

        for (int i = 1; i < str.Length; i++){
            if (freq[str[i]] > max){
                max = freq[str[i]];
                result = str[i];
            }
        }
        Console.WriteLine("Most Frequent Character: '" + result + "'");
    }
}
