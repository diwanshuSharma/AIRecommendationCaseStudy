using System;
using System.Collections.Generic;
using System.Text;

namespace AIRecommendationApp.PearsonEngine
{
    public interface IRecommendationEngine
    {
        double GetCorellation(List<int> baseList, List<int> otherList);
    }
}
