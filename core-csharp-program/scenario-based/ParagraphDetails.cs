using System;

class ParagraphDetails{
    static void Main(){
        Console.WriteLine("Enter a paragraph : ");
        string paragraph = Console.ReadLine();

        Console.WriteLine("Enter a word to be replaced : ");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter new word : ");
        string newWord = Console.ReadLine();

        int count = ProvideDetails(paragraph);
        Console.WriteLine("The word count is : " + count);

        Console.WriteLine("The String status being Empty is : " +  IsEmptyOrSpaces(paragraph));

        Console.WriteLine("The longest word is : " +  FindLongestWord(paragraph));

        Console.WriteLine("The sentence after replacing : " +  ReplaceWord(paragraph, oldWord, newWord));
    }

    static int ProvideDetails(string paragraph){
        int wordCount = 0;
        bool inWord = false;

        foreach (char ch in paragraph){
            if (ch != ' ' && !inWord){
                wordCount++;
                inWord = true;
            }
            else if (ch == ' '){
                inWord = false;
            }
        }
        return wordCount;
    }

    static bool IsEmptyOrSpaces(string paragraph){
        if (paragraph.Length == 0)    return true;

        for (int i = 0; i < paragraph.Length; i++){
            if (paragraph[i] != ' ')
                return false;
        }
        return true;
    }

    static string FindLongestWord(string text){
        string current = "";
        string longest = "";

        for (int i = 0; i <= text.Length; i++){
            if (i < text.Length && text[i] != ' '){
                current += text[i];
            }
            else{
                if (current.Length > longest.Length)    longest = current;

                current = "";
            }
        }
        return longest;
    }

    static string ReplaceWord(string text, string oldWord, string newWord){
        string result = "";
        string current = "";

        for (int i = 0; i <= text.Length; i++){
            if (i < text.Length && text[i] != ' '){
                current += text[i];
            }
            else{
                if (string.Equals(current, oldWord,StringComparison.OrdinalIgnoreCase))    result += newWord;
                else    result += current;

                if (i < text.Length)    result += " ";
                current = "";
            }
        }
        return result;
    }
}