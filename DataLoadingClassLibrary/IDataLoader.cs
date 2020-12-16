using BooksUsersClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLoadingClassLibrary
{
    interface IDataLoader
    {
        BookDetails Load();
    }
}
