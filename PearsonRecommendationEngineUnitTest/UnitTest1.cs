using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using AIRecommendationApp.PearsonEngine;

namespace PearsonRecommendationEngineUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckPearson()
        {
            PersonRecommendationEngine pearson = new PersonRecommendationEngine();
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            List<int> list2 = new List<int>();
            list2.Add(100);
            list2.Add(22);
            list2.Add(315);
            list2.Add(49);
            list2.Add(53);
            double result = pearson.GetCorrelation(list1, list2);
            double exp = -0.0889;
            Assert.AreEqual(exp, result);
        }
    }
}
