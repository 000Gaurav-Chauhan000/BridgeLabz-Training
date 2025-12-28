using System;

class NumberGuessingGame{
    static int GenerateGuess(int low, int high){
        return (low + high) / 2;
    }
    static string GetFeedback(){
        Console.WriteLine("Enter feedback (high / low / correct):");
        return Console.ReadLine().ToLower();
    }
    static void Main(){
        int low = 1;
        int high = 100;
        bool guessed = false;

        Console.WriteLine("Think of a number between 1 and 100");

        while (!guessed){
            int guess = GenerateGuess(low, high);
            Console.WriteLine("Computer guesses : " + guess);

            string feedback = GetFeedback();

            if (feedback == "correct")    guessed = true;
            else if (feedback == "high")    high = guess - 1;
            else if (feedback == "low")    low = guess + 1;
        }
        Console.WriteLine("Number guessed corect.");
    }
}
