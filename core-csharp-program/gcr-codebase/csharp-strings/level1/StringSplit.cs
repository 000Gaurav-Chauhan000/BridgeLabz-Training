using System;

class SplitWordsAndLengths{
    static int GetLength(string text){
        int count = 0;
        foreach (char c in text)
        {
            count++;
        }
        return count;
    }
    static string[,] SplitAndGetLengths(string text){
        int wordCount = 0;
        bool inWord = false;

        foreach (char c in text){
            if (c != ' ' && !inWord){
                wordCount++;
                inWord = true;
            }
            else if (c == ' '){
                inWord = false;
            }
        }

        string[,] result = new string[wordCount, 2];

        int index = 0;
        string currentWord = "";

        foreach (char c in text){
            if (c != ' '){
                currentWord += c;
            }
            else if (currentWord != ""){
                result[index, 0] = currentWord;
                result[index, 1] = GetLength(currentWord).ToString();
                index++;
                currentWord = "";
            }
        }

        if (currentWord != ""){
            result[index, 0] = currentWord;
            result[index, 1] = GetLength(currentWord).ToString();
        }
        return result;
    }

    static void Main(){
        Console.WriteLine("Enter a Line or a phrase : ");
        string text = Console.ReadLine();
        string[,] words = SplitAndGetLengths(text);

        for (int i = 0; i < words.GetLength(0); i++){
            Console.WriteLine(words[i, 0] + " : " + words[i, 1]);
        }
    }
}
