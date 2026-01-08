using Movie_Management_System;

class Program
{
    static void Main()
    {
        IMovieList movies = new MovieDoublyLinkedList();

        movies.AddAtBeginning("Movie 1", "Director 1", 2010, 8.8);
        movies.AddAtEnd("Movie 3", "Director 1", 2014, 8.6);
        movies.AddAtEnd("Movie 2", "Director 2", 2009, 7.8);

        Console.WriteLine("\nAll Movies (Forward):");
        movies.DisplayForward();

        Console.WriteLine("\nAll Movies (Reverse):");
        movies.DisplayReverse();

        Console.WriteLine("\nSearch by Director (Director 1):");
        movies.SearchByDirector("Director 1");

        Console.WriteLine("\nSearch by Rating >= 8.0:");
        movies.SearchByRating(8.0);

        Console.WriteLine("\nUpdate Rating of Movie 2:");
        movies.UpdateRating("Movie 2", 8.2);

        Console.WriteLine("\nRemove Movie: Movie 3");
        movies.RemoveByTitle("Movie 3");

        Console.WriteLine("\nFinal Movie List:");
        movies.DisplayForward();
    }
}
