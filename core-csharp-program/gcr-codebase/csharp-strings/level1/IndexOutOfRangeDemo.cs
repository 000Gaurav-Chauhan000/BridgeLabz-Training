using System;

class IndexOutOfRangeDemo{
    static void DemonstrateNullReference(){
        String str = "decoy";
        try
        {
             string temp = str.Substring(20); 
        }
        catch(IndexOutOfRangeException e){
            Console.WriteLine("IndexOutOfBounds Exception Caught !!\nMessage : " + e.Message);
        }
    }
    static void Main(){
        DemonstrateNullReference();
    }
}