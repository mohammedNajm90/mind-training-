using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Review r = new Review();
            MovieManager ma = new MovieManager();
            Console.WriteLine("Enter 1 if you are a user, Enter 2 if you are an admin");
            int role = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your password");
            string password = Console.ReadLine().ToLower();

            if ((role == 1 && password == "user") || (role == 2 && password == "admin"))
            {
                bool keepRunning = true;

                while (keepRunning)
                {
                    if (role == 1)
                    {
                        Console.WriteLine("\nUser Menu:");
                        Console.WriteLine("1. Display Movies");
                        Console.WriteLine("2. Display Reviews");
                        Console.WriteLine("3. Add Review");
                        Console.WriteLine("4. Exit");

                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                ma.ShowAllMovies();
                                break;
                            case 2:
                                Console.WriteLine("Enter the movie title to view its reviews:");
                                string titleToView = Console.ReadLine();
                                ma.ShowReviews(titleToView);
                                break;
                            case 3:
                                Console.WriteLine("Enter the movie title to write reviews:");
                                string titleToReview = Console.ReadLine();
                                ma.AddReview(titleToReview, r);
                                break;
                            case 4:
                                keepRunning = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                    }
                    else if (role == 2)
                    {
                        Console.WriteLine("\nAdmin Menu:");
                        Console.WriteLine("1. Display Movies");
                        Console.WriteLine("2. Display Reviews");
                        Console.WriteLine("3. Add Review");
                        Console.WriteLine("4. Add Movie");
                        Console.WriteLine("5. Exit");

                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                ma.ShowAllMovies();
                                break;
                            case 2:
                                Console.WriteLine("Enter the movie title to view its reviews:");
                                string titleToView = Console.ReadLine();
                                ma.ShowReviews(titleToView);
                                break;
                            case 3:
                                Console.WriteLine("Enter the movie title to write reviews:");
                                string titleToReview = Console.ReadLine();
                                Console.WriteLine("Enter your name:");
                                string reviewerName = Console.ReadLine();

                                Console.WriteLine("Enter your comment:");
                                string comment = Console.ReadLine();

                                Console.WriteLine("Enter your rating (1 to 10):");
                                int rating = int.Parse(Console.ReadLine());
                                Review re = new Review(titleToReview, reviewerName, comment, rating);

                                ma.AddReview(titleToReview, re);
                                break;
                            case 4:
                                Console.WriteLine("Enter movie title:");
                                string title = Console.ReadLine();

                                Console.WriteLine("Enter movie genre:");
                                string genre = Console.ReadLine();

                                Console.WriteLine("Enter movie year:");
                                int year = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter movie director:");
                                string director = Console.ReadLine();

                                Movie userMovie = new Movie(title, genre, year, director);
                                ma.AddMovie(userMovie);
                                break;
                            case 5:
                                keepRunning = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect password or role.");
            }

            Console.WriteLine("Program ended.");
            Console.ReadKey();
        }
    }
}
