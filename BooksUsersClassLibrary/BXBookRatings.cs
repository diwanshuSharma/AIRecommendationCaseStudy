using System;
using System.Collections.Generic;
using System.Text;

namespace BooksUsersClassLibrary
{
    class BXBookRatings
    {
        public BXUsers UserID { get; set; }
        public BXBooks ISBN { get; set; }
        public int BookRating { get; set; }

    }
}
