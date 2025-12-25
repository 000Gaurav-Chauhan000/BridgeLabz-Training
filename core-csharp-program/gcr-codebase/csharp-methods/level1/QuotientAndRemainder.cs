using System;

class QuotientAndRemainder
{
    static int[] quotientAndRemainder(int num1, int num2)
    {
        int[] result = new int[2];
        result[0] = num1 / num2;
        result[1] = num1 % num2;
        return result;
    }

    static void Main(){

        Console.WriteLine("enter the first number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter the second number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int[] ans = quotientAndRemainder(num1, num2);

        Console.WriteLine("quotient is : " + ans[0]);
        Console.WriteLine("remainder is : " + ans[1]);
    }
}
