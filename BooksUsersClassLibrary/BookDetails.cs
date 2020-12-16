using System;
using System.Collections.Generic;
using System.Text;

namespace BooksUsersClassLibrary
{
    public class BookDetails
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<BookUserRating> BookUserRatings { get; set; } = new List<BookUserRating>();
        public List<User> Users { get; set; } = new List<User>();

    }
}