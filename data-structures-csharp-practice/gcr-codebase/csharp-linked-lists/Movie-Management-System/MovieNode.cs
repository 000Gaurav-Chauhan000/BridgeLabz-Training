using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Management_System
{
    class MovieDoublyLinkedList : IMovieList
    {
        private MovieNode head;
        private MovieNode tail;

        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            newNode.Next = head;
            head.Previous = newNode;
            head = newNode;
        }

        public void AddAtEnd(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);

            if (tail == null)
            {
                head = tail = newNode;
                return;
            }

            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }

        public void AddAtPosition(int position, string title, string director, int year, double rating)
        {
            if (position <= 1)
            {
                AddAtBeginning(title, director, year, rating);
                return;
            }

            MovieNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.Next;

            if (temp == null || temp.Next == null)
            {
                AddAtEnd(title, director, year, rating);
                return;
            }

            MovieNode newNode = new MovieNode(title, director, year, rating);

            newNode.Next = temp.Next;
            newNode.Previous = temp;
            temp.Next.Previous = newNode;
            temp.Next = newNode;
        }

        public void RemoveByTitle(string title)
        {
            MovieNode temp = head;

            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (temp == head)
                    {
                        head = head.Next;
                        if (head != null) head.Previous = null;
                    }
                    else if (temp == tail)
                    {
                        tail = tail.Previous;
                        tail.Next = null;
                    }
                    else
                    {
                        temp.Previous.Next = temp.Next;
                        temp.Next.Previous = temp.Previous;
                    }

                    Console.WriteLine("Movie removed.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Movie not found.");
        }

        public void SearchByDirector(string director)
        {
            MovieNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
                {
                    PrintMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found for this director.");
        }

        public void SearchByRating(double rating)
        {
            MovieNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Rating >= rating)
                {
                    PrintMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found with this rating.");
        }

        public void UpdateRating(string title, double newRating)
        {
            MovieNode temp = head;

            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Rating updated.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Movie not found.");
        }

        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            MovieNode temp = head;
            while (temp != null)
            {
                PrintMovie(temp);
                temp = temp.Next;
            }
        }

        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            MovieNode temp = tail;
            while (temp != null)
            {
                PrintMovie(temp);
                temp = temp.Previous;
            }
        }

        private void PrintMovie(MovieNode movie)
        {
            Console.WriteLine(
                $"Title: {movie.Title}, Director: {movie.Director}, Year: {movie.Year}, Rating: {movie.Rating}"
            );
        }
    }

}
