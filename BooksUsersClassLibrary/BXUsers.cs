﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BooksUsersClassLibrary
{
    class BXUsers
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
        
    }
}
