using System;

namespace OOPExcercises
{
    public class Book
    {
        public String Title { get; protected set; }
        public String Author { get; protected set; }
        public int Price { get; protected set; }

        public Book (String title,String author,int price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        public double get_discounted_price (double percent) =>Price -(Price * (percent / 100));
        
    }
}
