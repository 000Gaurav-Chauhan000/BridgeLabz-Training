using System;

class ChocolateDistribution
{
    static int[] distributeChocolates(int chocolates, int children)
    {
        int[] result = new int[2];
        result[0] = chocolates / children;
        result[1] = chocolates % children;
        return result;
    }

    static void Main()
    {
        Console.WriteLine("enter number of chocolates : ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter number of children : ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        int[] ans = distributeChocolates(numberOfChocolates, numberOfChildren);

        Console.WriteLine("each child gets : " + ans[0] + " chocolates");
        Console.Write("remaining chocolates: "+ ans[1]);
    }
}
