using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using AIRecommendationApp.PearsonEngine;

namespace PearsonRecommendationEngineUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        static PersonRecommendationEngine pearson = null;

        [TestInitialize]
        public void Initialize()
        {
            pearson = new PersonRecommendationEngine();
        }

        [TestCleanup]
        public void Clean()
        {
            pearson = null;
        }

         [TestMethod]
         public void PearsonEngine_OnSameLength_ReturnDouble()
         {
             List<int> a = new List<int> { 1, 2, 3, 4, 5 };
             List<int> b = new List<int> { 1, 2, 2, 2, 3 };
             double expected = 0.89;
             double actual = pearson.GetCorrelation(a, b);
             Assert.AreEqual(expected, Math.Round(actual, 2));
         }

         [TestMethod]
         public void PearsonEngine_BaseLengthLarger_ReturnDouble()
         {
             List<int> a = new List<int> { 1, 2, 3, 4, 5, 6 };
             List<int> b = new List<int> { 1, 2, 2, 2, 3 };
             double expected = 0.08;
             double actual = pearson.GetCorrelation(a, b);
             Assert.AreEqual(expected, Math.Round(actual, 2));
         }

         [TestMethod]
         public void PearsonEngine_BaseLengthSmaller_ReturnDouble()
         {
             List<int> a = new List<int> { 1, 2, 3, 4 };
             List<int> b = new List<int> { 1, 2, 2, 2, 3 };
             double expected = 0.77;
             double actual = pearson.GetCorrelation(a, b);
             Assert.AreEqual(expected, Math.Round(actual, 2));
         }
        
    }
}
