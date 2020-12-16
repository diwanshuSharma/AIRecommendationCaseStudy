using System;
using System.Collections.Generic;
using System.Text;

namespace BooksUsersClassLibrary
{
    public class BookUserRating
    {
        public User UserID { get; set; }
        public Book ISBN { get; set; }
        public int BookRating { get; set; }

    }
}
