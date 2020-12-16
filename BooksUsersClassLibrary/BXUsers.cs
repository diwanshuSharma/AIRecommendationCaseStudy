using System;
using System.Collections.Generic;
using System.Text;

namespace BooksUsersClassLibrary
{
    public class User
    {
        public int UserID { get; set; }
        public int Age { get; set; }

        public Location LocationID
        {
            get => default;
            set
            {
            }
        }
        public List<BookUserRating> BookUserRatings { get; set; }

    }
}
