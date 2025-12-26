using System;

class SubStringMethod{
    static string MakeSubString(string s1, int start, int end){
        string temp = "";

        for (int i = start; i <= end; i++){
            temp += s1[i];
        }
        return temp;
    }

    static void Main()
    {
        Console.WriteLine("Enter string s1 : ");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the start Index : ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the end Index : ");
        int end = Convert.ToInt32(Console.ReadLine());

        if (start < 0 || end >= str1.Length || start > end){
            Console.WriteLine("Invalid index values");
            return;
        }
        Console.WriteLine("Substring using custom method : " +
            MakeSubString(str1, start, end));

        Console.WriteLine("Substring using built-in method : " +
            str1.Substring(start, end-start+1));
    }
}
