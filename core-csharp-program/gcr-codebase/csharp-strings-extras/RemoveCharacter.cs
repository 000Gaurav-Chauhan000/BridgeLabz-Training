using System;

class RemoveCharacter{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        Console.WriteLine("Enter character to remove:");
        char removeChar = Console.ReadLine()[0];

        string result = "";

        for (int i = 0; i < str.Length; i++){
            if (str[i] != removeChar)
                result += str[i];
        }
        Console.WriteLine("Modified String: " + result);
    }
}
