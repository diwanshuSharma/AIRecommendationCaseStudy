using DataLoadingClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRecommendationCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVDataLoader load = new CSVDataLoader();
            load.Load();
        }
    }
}
