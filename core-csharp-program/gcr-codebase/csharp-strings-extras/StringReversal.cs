using System;

class StringRe{
    static void Main(){
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        string reverse = "";
        for (int i = str.Length - 1; i >= 0; i--){
            reverse += str[i];
        }
        Console.WriteLine("Reversed string: " + reverse);
    }
}
