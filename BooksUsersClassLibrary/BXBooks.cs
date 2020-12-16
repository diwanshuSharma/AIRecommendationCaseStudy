using System;
using System.Collections.Generic;
using System.Text;

namespace BooksUsersClassLibrary
{
    public class Book
    {
        public string ISBN { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int YearOfPublication { get; set; }
        public string Publisher { get; set; }
        public string ImageURLS { get; set; }
        public string ImageURLM { get; set; }
        public string ImageURLL { get; set; }
        public List<BookUserRating> BookUserRating { get; set; } = new List<BookUserRating>();

    }
}
