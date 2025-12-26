using System;

class UpperCaseDemo{
    static string ConvertLowerCase(string str){
        char[] result = new char[str.Length];
        for (int i = 0; i < str.Length; i++){
            char ch = str[i];
            if (ch >= 'A' && ch <= 'Z'){
                result[i] = (char)(ch + 32);
            }
            else{
                result[i] = ch;
            }
        }
        return new string(result);
    }
    static void Main(){
        string text = Console.ReadLine();
        string Lower = ConvertLowerCase(text);
        string builtInLower = text.ToLower();

        Console.WriteLine("Implemented Method : "+Lower);
        Console.WriteLine("By Built-In method : "+builtInLower);
    }
}