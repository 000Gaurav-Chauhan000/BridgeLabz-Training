using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Management_System
{
    public interface IMovieList
    {
        void AddAtBeginning(string title, string director, int year, double rating);
        void AddAtEnd(string title, string director, int year, double rating);
        void AddAtPosition(int position, string title, string director, int year, double rating);

        void RemoveByTitle(string title);
        void SearchByDirector(string director);
        void SearchByRating(double rating);

        void UpdateRating(string title, double newRating);

        void DisplayForward();
        void DisplayReverse();
    }
}
