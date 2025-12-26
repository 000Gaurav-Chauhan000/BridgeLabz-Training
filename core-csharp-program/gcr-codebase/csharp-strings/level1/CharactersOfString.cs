using System;

class CharactersOfString {
    static  char[] DisplayCharacters(String str){
        char[] temp = new char[str.Length];

        for(int i = 0;i < str.Length; i++){
            temp[i] = str[i];
        }
        return temp;
    }


    static void Main(){
        Console.WriteLine("Enter the String : ");
        String str = Console.ReadLine();

        char[] result = DisplayCharacters(str);

        Console.WriteLine("The array Elements are : ");

         for(int i = 0; i < str.Length; i++){
            Console.Write(result[i] + " ");
        }
    }
}