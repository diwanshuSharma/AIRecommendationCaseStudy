using BooksUsersClassLibrary;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace DataLoadingClassLibrary
{
    public class CSVDataLoader : IDataLoader
    {
        List<Book> Books = new List<Book>();
        List<User> Users = new List<User>();
        List<BookUserRating> BookUserRatings = new List<BookUserRating>();
        BookDetails BookDetails = new  BookDetails();

        CSVDataLoader()
        {
            LoadBooks();
            LoadUsers();
            LoadRatings();
            LoadBookDetails();
        }

        public BookDetails Load()
        {
            return BookDetails;
            //throw new NotImplementedException();
        }

        private void LoadBookDetails()
        {
            throw new NotImplementedException();
        }

        private void LoadRatings()
        {
            throw new NotImplementedException();
        }

        private void LoadUsers()
        {
            throw new NotImplementedException();
        }

        private void LoadBooks()
        {
            throw new NotImplementedException();
        }
    }
}