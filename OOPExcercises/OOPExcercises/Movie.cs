using System;


namespace OOPExcercises
{
    public class Movie
    {
        public string Title { get; protected set; }
        public string Director { get; protected set; }
        public int Year { get; protected set; }

        public Movie(string title, string director, int year)
        {
            Title = title;
            Director = director;
            Year = year;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Title: {Title}, Director: {Director}, Year: {Year}");
        }
    }

}
