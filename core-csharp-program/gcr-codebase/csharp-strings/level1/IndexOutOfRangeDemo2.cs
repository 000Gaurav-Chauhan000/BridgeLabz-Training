using System;

class IndexOutOfRangeDemo2{
    static void DemonstrateIndexOutOfBounds(){
        String[] arr = new string[5];
        try{
            Console.WriteLine(arr[5]); 
        }
        catch(IndexOutOfRangeException e){
            Console.WriteLine("IndexOutOfBounds Exception Caught !!\nMessage : " + e.Message);
        }
    }
    static void Main(){
        DemonstrateIndexOutOfBounds();
    }
}