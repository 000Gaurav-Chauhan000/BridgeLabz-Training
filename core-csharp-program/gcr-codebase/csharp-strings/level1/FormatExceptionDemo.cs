using System;

class FormatExceptionDemo{
    
    static void DemonstrateFormatException(){
        String s = "Decoy";
        try{
        int a = int.Parse(s);

        }
        catch (Exception e){
            Console.WriteLine("FormatException caught !!\nMessage : " + e.Message);
        }
    }
    static void Main(){
        DemonstrateFormatException();
    }
}