using CS350_BaggingApplication.Models;
using System;
using System.Collections.Generic;

public class SimpleBaggingAlgorithm : IBaggingAlgorithm
{
    public int GetNumberOfNeededBags(Dictionary<Item, int> dict, Packaging packagingType)
    {
        double totalItems = 0;
        double totalWeight = 0;
        foreach (var item in dict)
        {
            if (item.Value != 0)
            {
                totalItems += item.Value;
                totalWeight += item.Key.Weight;
            }
        }

        var totalBags = Math.Max((int)Math.Ceiling(totalWeight / packagingType.WeightCapacity), 
                                (int)Math.Ceiling(totalItems / packagingType.HardItemLimit));

        return (totalBags > 0) ? totalBags : 1;
    }
}