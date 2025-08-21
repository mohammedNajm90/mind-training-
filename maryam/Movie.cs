using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review_App
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        //public Movie(string title, string author, int releaseDate,string genre,int rating)
        //{
        //    Title = title;
        //    Author = author;
        //    ReleaseDate = releaseDate;
        //    Genre = genre;
        //    Rating = rating;
        //}
        public Movie(string title, string author, int releaseDate, string genre)
        {
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
            Genre = genre;

        }

        public void ShowDetails()
        {
            Console.WriteLine(" Movie Details:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ReleaseDate : {ReleaseDate}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Rating: {Rating}/10");
            Console.WriteLine("-------------------------------");
        }

    }
}