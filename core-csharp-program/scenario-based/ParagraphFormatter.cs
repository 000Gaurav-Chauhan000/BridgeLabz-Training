using System;

class ParagraphFormatter{
    static void Main(){
        Console.Write("Enter a paragraph or a line:\n");
        string para = Console.ReadLine();
        FormatThis(para);
    }

    static void FormatThis(string paragraph){
        if (paragraph.Length == 0){
            Console.WriteLine("Empty String");
            return;
        }

        string result = "";
        bool lastSpace = false;
        bool capitalizeNext = true;

        for (int i = 0; i < paragraph.Length; i++){
            char ch = paragraph[i];

            if (ch == ' '){
                if (!lastSpace && result.Length > 0){
                    result += ' ';
                    lastSpace = true;
                }
                continue;
            }

            lastSpace = false;

            if (capitalizeNext && ch >= 'a' && ch <= 'z'){
                ch = (char)(ch - 32);
                capitalizeNext = false;
            }
            else if (ch >= 'A' && ch <= 'Z'){
                capitalizeNext = false;
            }

            result += ch;

            if ((ch == ',' || ch == '.' || ch == '?' || ch == '!') &&
                i + 1 < paragraph.Length &&
                paragraph[i + 1] != ' '){
                result += ' ';
                lastSpace = true;
            }

            if (ch == '.' || ch == '?' || ch == '!'){
                capitalizeNext = true;
            }
        }
        Console.WriteLine(result);
    }
}
