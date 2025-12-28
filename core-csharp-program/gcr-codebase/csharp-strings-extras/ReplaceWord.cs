using System;

class ReplaceWord{
    static string Replace(string sentence, string oldWord, string newWord){
        string result = "";
        string temp = "";

        for (int i = 0; i < sentence.Length; i++){
            if (sentence[i] != ' '){
                temp += sentence[i];
            }
            else{
                if (temp == oldWord)    result += newWord + " ";
                else    result += temp + " ";
                temp = "";
            }
        }

        if (temp == oldWord)    result += newWord;
        else    result += temp;
        return result;
    }
    static void Main(){
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        Console.WriteLine("Enter word to replace:");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter new word:");
        string newWord = Console.ReadLine();

        Console.WriteLine("Modified Sentence:");
        Console.WriteLine(Replace(sentence, oldWord, newWord));
    }
}
