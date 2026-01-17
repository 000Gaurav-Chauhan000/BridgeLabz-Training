using System;

namespace BookShelf
{
    class Program
    {
        static void Main()
        {
            Library library = new Library();
            int choice;

            do
            {
                Console.WriteLine("\n=== Library Menu ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display Library");
                Console.WriteLine("4. Exit");
                Console.Write("Choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Genre: ");
                        string genre = Console.ReadLine();
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Author: ");
                        string author = Console.ReadLine();
                        library.AddBook(genre, title, author);
                        break;

                    case 2:
                        Console.Write("Genre: ");
                        string g = Console.ReadLine();
                        Console.Write("Title: ");
                        string t = Console.ReadLine();
                        library.RemoveBook(g, t);
                        break;

                    case 3:
                        library.Display();
                        break;
                }

            } while (choice != 4);
        }
    }
}
