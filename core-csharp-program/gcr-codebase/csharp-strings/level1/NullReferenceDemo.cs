using System;

class NullReferenceDemo{
    static void DemonstrateNullReference(){
        try{
            string message = null;   
            int length = message.Length;
            Console.WriteLine("Length of the string: " + length);
        }
        catch (NullReferenceException e){
            Console.WriteLine("NullReferenceException caught!!\nMessage : "+ e.Message);
        }
    }

    static void Main(){
        DemonstrateNullReference();
    }
}
