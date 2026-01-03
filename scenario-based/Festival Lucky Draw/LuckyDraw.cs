using System;

namespace Festival_Lucky_Draw{
    internal class LuckyDraw{
        public static void RunApplication(){
            Console.WriteLine("========== Welcome to the Diwali Mela! ==========");
            Console.WriteLine("Enter the number of people : ");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 1; i <= numberOfPeople; i++){
                int draw = rnd.Next(1, 1000);
                if (draw % 5 == 0 && draw % 3 == 0){
                    Console.WriteLine($"Entry no. {i} has won the prize.");
                    youWon();
                }
            }

        }
        private static void youWon(){
            Console.WriteLine("Congratulations! You have won a special gift");
        }
    }
}