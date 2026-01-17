using System;
using System.Collections.Generic;

namespace BookShelf
{
    internal class Library
    {
        private Dictionary<string, LinkedList<Book>> catalog =
            new Dictionary<string, LinkedList<Book>>();

        private HashSet<string> uniqueBooks = new HashSet<string>();

        public void AddBook(string genre, string title, string author)
        {
            string key = title + author;

            if (!uniqueBooks.Add(key))
            {
                Console.WriteLine("Duplicate book not allowed.");
                return;
            }
            
            if (!catalog.ContainsKey(genre))
                catalog[genre] = new LinkedList<Book>();

            catalog[genre].AddLast(new Book(title, author));
            Console.WriteLine("Book added.");
        }

        public void RemoveBook(string genre, string title)
        {
            if (!catalog.ContainsKey(genre))
            {
                Console.WriteLine("Genre not found.");
                return;
            }

            var list = catalog[genre];
            var node = list.First;

            while (node != null)
            {
                if (node.Value.Title == title)
                {
                    uniqueBooks.Remove(node.Value.Title + node.Value.Author);
                    list.Remove(node);
                    Console.WriteLine("Book removed.");
                    return;
                }
                node = node.Next;
            }

            Console.WriteLine("Book not found.");
        }

        public void Display()
        {
            if (catalog.Count == 0)
            {
                Console.WriteLine("Library empty.");
                return;
            }

            foreach (var genre in catalog)
            {
                Console.WriteLine($"\nGenre: {genre.Key}");
                foreach (var book in genre.Value)
                    Console.WriteLine("  " + book);
            }
        }
    }
}