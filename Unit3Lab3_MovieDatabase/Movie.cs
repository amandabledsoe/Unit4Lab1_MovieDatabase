using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4Lab1_MovieDatabase
{
    public class Movie
    {
        public string Title {get; set;}
        public string Category {get; set;}
        public int RunTimeInMinutes { get; set;}
        public DateTime YearReleased {get; set;}

        public Movie(string title, string category, int runTimeInMinutes, DateTime yearReleased)
        {
            Title = title;
            Category = category;
            RunTimeInMinutes = runTimeInMinutes;
            YearReleased = yearReleased;
        }
    }
}
