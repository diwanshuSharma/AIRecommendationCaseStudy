using BooksUsersClassLibrary;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Data;
using System.IO;

namespace DataLoadingClassLibrary
{
    public class CSVDataLoader : IDataLoader
    {
        public BookDetails Load()
        {

            var csvTable = new DataTable();

            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"C:\Eurofins-Training\RecommendationEngine_Project\BX-CSV-Dump\BX_Books.csv")), true))
            {
                csvTable.Load(csvReader);
            }

            Console.WriteLine(csvTable.ToString());

            throw new NotImplementedException();
        }
    }
}