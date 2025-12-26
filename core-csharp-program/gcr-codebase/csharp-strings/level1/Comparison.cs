using System;

class Comparison{
    static bool Compare2Strings(String s1, String s2){
        
        if (s1.Length == s2.Length){
            for(int i = 0; i < s1.Length; i++){
               if(s1[i] != s2[i]) return false;
            }
        }
        else{
            return false;
        }
        return true;
    }

    static void Main(){
        Console.WriteLine("Enter the first String : ");
        String st1 = Console.ReadLine();

        Console.WriteLine("Enter the second String : ");
        String st2 = Console.ReadLine();

        Console.WriteLine("The results from both the methods are : ");

        Console.WriteLine("By In-Built method : "+(st1.Equals(st2)));      
        Console.WriteLine("By implemented method : "+ (Compare2Strings(st1,st2)));

    }
}