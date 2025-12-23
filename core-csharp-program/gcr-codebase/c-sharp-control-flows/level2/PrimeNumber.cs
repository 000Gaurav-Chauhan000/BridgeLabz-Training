using System;

class PrimeNumber{
    static void Main(){
      Console.WriteLine("Enter a number : ");

        bool flag = true;
      int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= Math.Sqrt(num) ; i++)
        {
            if (num % i == 0)
            {
                flag = false;
            }
        }  
        Console.WriteLine("The given number being prime is : " + flag);
    }
}