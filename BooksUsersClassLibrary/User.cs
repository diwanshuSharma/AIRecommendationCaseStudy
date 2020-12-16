using System;
using System.Collections.Generic;
using System.Text;

namespace BooksUsersClassLibrary
{
    public class User
    {
        public int UserID { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Coutry { get; set; }
        public List<BookUserRating> BookUserRatings { get; set; } = new List<BookUserRating>();

    }
}
