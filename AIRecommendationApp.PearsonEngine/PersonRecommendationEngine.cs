using System;
using System.Collections.Generic;

namespace AIRecommendationApp.PearsonEngine
{
    public class PersonRecommendationEngine : IRecommendationEngine
    {
        public double GetCorellation(List<int> baseList, List<int> otherList)
        {
            int len1 = baseList.Count, len2 = otherList.Count;
            int[] tbaseList, totherList;
            int minLength = Math.Min(len1, len2);

            if (len1 != len2)
            {
                if (len1 < len2)                                  //Second Array is larger
                {
                    tbaseList = new int[minLength];
                    totherList = new int[minLength];
                    for (int i = 0; i < Math.Min(len1, len2); i++)
                    {
                        tbaseList[i] = baseList[i];
                        totherList[i] = otherList[i];
                    }
                }
                else                                            //First Array is larger
                {
                    tbaseList = new int[baseList.Count];
                    baseList.CopyTo(tbaseList);
                    totherList = new int[baseList.Count];
                    for (int i = 0; i < baseList.Count; i++)
                    {
                        if (i < minLength)
                        {
                            totherList[i] = otherList[i];
                            Console.WriteLine("Less length");
                        }
                        else
                        {
                            tbaseList[i] += 1;
                            totherList[i] += 1;
                            Console.WriteLine("More length");
                        }
                    }
                }
            }
            else                                                //Same Length
            {
                tbaseList = new int[baseList.Count];
                totherList = new int[otherList.Count];
                baseList.CopyTo(tbaseList);
                otherList.CopyTo(totherList);
            }
            for (int i = 0; i < tbaseList.Length; i++)                 //If there are any zeros
            {
                if (tbaseList[i] == 0 || totherList[i] == 0)
                {
                    tbaseList[i] += 1;
                    totherList[i] += 1;
                }
            }

            /*
            Console.WriteLine("The array are now : ");
            for (int i = 0; i < tbaseList.Length; i++)
            {
                Console.WriteLine($"{tbaseList[i]}\t{totherList[i]}");
            }
            */

            return CalculatePearson(tbaseList, totherList);
        }

        private static double CalculatePearson(int[] baseList, int[] otherList)
        {
            double mean1 = 0, mean2 = 0;
            double numerator = 0, deno1 = 0, deno2 = 0;

            foreach (int elem in baseList)
            {
                mean1 += elem;
            }
            foreach (int elem in otherList)
            {
                mean2 += elem;
            }
            mean1 /= 10;
            mean2 /= 10;

            //Console.WriteLine($"Mean are {mean1} and {mean2}");

            for (int i = 0; i < baseList.Length; i++)
            {
                numerator += (baseList[i] - mean1) * (otherList[i] - mean2);
                deno1 += (baseList[i] - mean1) * (baseList[i] - mean1);
                deno2 += (otherList[i] - mean2) * (otherList[i] - mean2);
            }

            double pearson = (numerator) / (Math.Sqrt(deno1 * deno2));
            return pearson;
        }
    }
}
