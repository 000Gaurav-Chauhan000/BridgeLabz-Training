using System;

class Book
{
    public static string LibraryName = "City Central Library";

    public string Title;
    public string Author;
    public readonly string ISBN;

    public Book(string Title, string Author, string ISBN)
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine(LibraryName);
    }

    public void DisplayDetails(object obj)
    {
        if (obj is Book)
        {
            Console.WriteLine(Title);
            Console.WriteLine(Author);
            Console.WriteLine(ISBN);
        }
    }

    static void Main(){
        Book b1 = new Book("Kudrat", "Rampal Desai", "ISBN1");
        Book b2 = new Book("Sheesha", "Kishore Kumar", "ISBN2");

        Book.DisplayLibraryName();

        b1.DisplayDetails(b1);
        b2.DisplayDetails(b2);
    }
}