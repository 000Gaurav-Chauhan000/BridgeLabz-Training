using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Management_System
{
    class MovieNode : IMovie
    {
        private string title;
        private string director;
        private int year;
        private double rating;

        public MovieNode Next { get; set; }
        public MovieNode Previous { get; set; }

        public string Title => title;
        public string Director => director;
        public int Year => year;

        public double Rating
        {
            get => rating;
            set => rating = value;
        }

        public MovieNode(string title, string director, int year, double rating)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.rating = rating;
            Next = null;
            Previous = null;
        }
    }

}
