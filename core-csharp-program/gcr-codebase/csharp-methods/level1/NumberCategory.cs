using System;

class NumberCategory{
    static int numberType(int number){
        if(number > 0)
        {
            return 1;
        }
        else if(number < 0){
            return -1;
        }
        else
        {
            return 0;
        }
    }

    static void Main(){
        Console.WriteLine("Enter a number : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(numberType(number));
    }
}