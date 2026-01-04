using System;

class Book{
    public string Title;
    public int PublicationYear;

    public Book(string title, int year){
        Title = title;
        PublicationYear = year;
    }
}

class Author : Book{
    public string Name;
    public string Bio;

    public Author(string title, int year, string name, string bio): base(title, year){
        Name = name;
        Bio = bio;
    }

    public void DisplayInfo(){
        Console.WriteLine(Title);
        Console.WriteLine(PublicationYear);
        Console.WriteLine(Name);
        Console.WriteLine(Bio);
    }
}

class Program{
    static void Main(){
        Author a1 = new Author("Another", 2009, "Li Ming","An author");

        a1.DisplayInfo();
    }
}
