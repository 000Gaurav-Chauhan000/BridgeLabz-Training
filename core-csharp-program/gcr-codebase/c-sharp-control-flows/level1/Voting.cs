using System;
class Voting {
    static void Main(){
        Console.WriteLine("Enter your age : ");
        int age = Convert.ToInt32(Console.ReadLine());

        if(age >= 18){
        Console.WriteLine("The person with age " + age + " can vote");
        }
        else{
            Console.WriteLine("The person with age " + age + " cannot vote");
        }
    }
}