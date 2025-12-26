using System;

class ArgumentOutOfRangeDemo{
    static void DemonstrateArgumentOutOfRange(){
        try{
            string text = "DecoyButBigger";
            string result = text.Substring(15, 20);

            Console.WriteLine(result);
        }
        catch (ArgumentOutOfRangeException ex){
            Console.WriteLine("ArgumentOutOfRangeException caught!");
            Console.WriteLine("Flash Message: " + ex.Message);
        }
    }
        static void Main(){
        DemonstrateArgumentOutOfRange();
    }
}
