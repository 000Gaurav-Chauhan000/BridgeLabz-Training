using System;

class Book
{
    string title;
    string author;
    double price;

    public Book(string t, string a, double p)
    {
        title = t;
        author = a;
        price = p;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
     static void Main(){
        Console.Write("Enter title: ");
        string title = Console.ReadLine();

        Console.Write("Enter author: ");
        string author = Console.ReadLine();

        Console.Write("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Book book = new Book(title, author, price);
        book.DisplayDetails();
    }
}