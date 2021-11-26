using CS350_BaggingApplication.Models;
using System.Collections.Generic;

public interface IBaggingAlgorithm
{
    int GetNumberOfNeededBags(Dictionary<Item, int> dict, Packaging packagingType);
}
