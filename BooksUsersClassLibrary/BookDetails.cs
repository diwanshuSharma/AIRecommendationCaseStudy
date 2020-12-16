using System;
using System.Collections.Generic;
using System.Text;

namespace BooksUsersClassLibrary
{
    public class BookDetails
    {
        public List<Book> Books { get; set; }
        public List<BookUserRating> BookUserRatings { get; set; }
        public List<User> Users { get; set; }

    }
}