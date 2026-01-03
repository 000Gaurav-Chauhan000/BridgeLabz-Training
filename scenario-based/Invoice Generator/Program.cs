using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter invoice details:");
        string input = Console.ReadLine();

        string[] tasks = InvoiceGenerator.ParseInvoice(input);
        int totalAmount = InvoiceGenerator.GetTotalAmount(tasks);

        Console.WriteLine("\nInvoice Details:");

        foreach (string task in tasks){
            Console.WriteLine(task);
        }

        Console.WriteLine("\nTotal amount: " + totalAmount);
    }
}
