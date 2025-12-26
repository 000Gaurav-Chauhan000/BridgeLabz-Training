using System;

class UpperCaseDemo{
    static string ConvertUpperCase(string str){
        char[] result = new char[str.Length];

        for (int i = 0; i < str.Length; i++){
            char ch = str[i];
            if (ch >= 'a' && ch <= 'z'){
                result[i] = (char)(ch - 32);
            }
            else{
                result[i] = ch;
            }
        }
        return new string(result);
    }

    static void Main(){
        string text = Console.ReadLine();
        string Upper = ConvertUpperCase(text);
        string builtInUpper = text.ToUpper();

        Console.WriteLine("Implemented Method : "+Upper);
        Console.WriteLine("By Built-In method : "+builtInUpper);
    }
}
