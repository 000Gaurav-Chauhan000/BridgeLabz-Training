using System;

class UniversityFees
{
    static void Main()
    {
        double fees = 125000;
        double discountPercent = 10;

        double discount = fees * discountPercent / 100;
        double finalFees = fees - discount;

        Console.WriteLine("The discount amount is INR " + discount + " and the final discounted fee is INR " + finalFees);

    }
}
