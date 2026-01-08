using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Management_System
{
    public interface IMovie
    {
        string Title { get; }
        string Director { get; }
        int Year { get; }
        double Rating { get; set; }
    }
}
