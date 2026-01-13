using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_Time
{
    internal class Menu
    {
        IMovieManager im = new MovieUtility();

        public void DisplayMenu()
        {
            Console.WriteLine("=========Welcooome=========:\n\n");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Display Movies");
            Console.WriteLine("3. Search Movie");
            Console.WriteLine("4. Exit");

            while (true)
            {
                Console.WriteLine("enter choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                  
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Adding movie ...");
                        im.AddMovie();
                        break;

                    case 2:
                        Console.WriteLine("Displaying movies : ");
                        im.DisplayMovies();
                    break;

                    case 3:
                        Console.WriteLine("Searching movie...");
                        Console.WriteLine(im.SearchMovie("Ste"));
                        break;

                    case 4:
                        Console.WriteLine("Exiting application...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select between 1 and 4.");
                        break;
                }
            }
        }
    }
}