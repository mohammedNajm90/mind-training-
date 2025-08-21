using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review_App
{
    internal class MovieManager
    {
        private List<Movie> movies = new List<Movie>();
        private Dictionary<string, List<Review>> reviews = new Dictionary<string, List<Review>>();

        public void AddMovie(Movie movie)
        {

            movies.Add(movie);
            Console.WriteLine($"Movie added successfully : {movie.Title}");
        }

        public void ShowAllMovies()
        {
            foreach (var movie in movies)
            {
                movie.ShowDetails();
            }
        }
        public void AddReview(string title, Review review)
        {
            if (reviews.ContainsKey(title))
            {
                reviews[title].Add(review);
            }
            else
            {
                reviews[title] = new List<Review> { review };
            }

            Console.WriteLine($"Review added for movie: {title}");
        }

        public void ShowReviews(string title)
        {
            if (reviews.ContainsKey(title))
            {
                Console.WriteLine($"Reviews for {title}:");
                foreach (var review in reviews[title])
                {
                    Console.WriteLine($"{review.ReviewerName} {review.Rating}/10");
                    Console.WriteLine($"{review.Comments}");
                    Console.WriteLine("-----------------------------");
                }
            }
            else
            {
                Console.WriteLine($"No reviews found for movie: {title}");
            }
        }


    }
}