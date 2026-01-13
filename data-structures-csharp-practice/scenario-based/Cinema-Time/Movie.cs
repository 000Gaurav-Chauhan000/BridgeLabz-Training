using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_Time
{
    public class Movie
    {
        public string Title { get; set; }
        public string Time { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Time}";
        }
    }
}
