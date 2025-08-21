using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review_App
{
    internal class Review
    {
        public string TitleToReview { get; set; }

        public string ReviewerName { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
        public Review()
        {

        }

        public Review(string titleToReview, string reviewerName, string comments, int rating)
        {
            TitleToReview = titleToReview;
            ReviewerName = reviewerName;
            Comments = comments;
            Rating = rating;
        }

    }
}