using System;
class MultiplicationTable{
    static void Main() {

        Console.WriteLine("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i =6; i<=9 ; i++){

            Console.WriteLine(num + " x " + i +" = " + (i*num));
        }
    }
}