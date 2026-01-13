using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_Time
{
    public interface IMovieManager{

        void AddMovie();
        
        void DisplayMovies();

        String SearchMovie(String title);

    }
}
