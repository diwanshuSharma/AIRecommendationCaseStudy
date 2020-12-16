using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRecommendationApp.PearsonEngine
{
    public class PersonRecommendationEngine : IRecommendationEngine
    {
        public double GetCorrelation(List<int> baselist, List<int> otherlist)
        {
            if (baselist.Count != otherlist.Count)
            {
                if (baselist.Count > otherlist.Count)
                {
                    int difference = baselist.Count - otherlist.Count;
                    for (int i = 0; i < difference; i++)
                    {
                        otherlist.Add(1);
                    }
                }
                else
                {
                    int difference = otherlist.Count - baselist.Count;
                    int j = baselist.Count;
                    for (int i = 0; i < difference; i++)
                    {
                        otherlist.RemoveAt(j++);
                    }
                }
            }

            foreach (int item in baselist)
            {
                if (item == 0)
                {
                    int position = baselist.IndexOf(item);
                    otherlist[position] += 1;
                }
            }

            foreach (int item in otherlist)
            {
                if (item == 0)
                {
                    int position = otherlist.IndexOf(item);
                    baselist[position] += 1;
                }
            }
            double avg1 = baselist.Average();
            double avg2 = otherlist.Average();
            var sum1 = baselist.Zip(otherlist, (x1, y1) => (x1 - avg1) * (y1 - avg2)).Sum();

            var sumSqr1 = baselist.Sum(x => Math.Pow((x - avg1), 2.0));
            var sumSqr2 = otherlist.Sum(y => Math.Pow((y - avg2), 2.0));

            var result = sum1 / Math.Sqrt(sumSqr1 * sumSqr2);
            result = (double)decimal.Round((decimal)result, 4);
            return result;
        }
    }
}
