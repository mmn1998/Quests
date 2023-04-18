using System;
using System.Collections.Generic;


namespace QueraQuests.SandTowers;

internal class SandTowers
{
    private readonly int? _totalTowers;
    private readonly List<long>? _towerHeights;

    public SandTowers(int? TotalTowers = null, List<long>? TowerHeights = null)
    {
        _totalTowers = TotalTowers;
        _towerHeights = TowerHeights;
    }
    public int CalculateMostBlocksForSortation()
    {
        int maxBlocksNeededForSortation = 0;

        try
        {
            if ((_totalTowers is null) || (_towerHeights is null) || (_totalTowers != _towerHeights.Count))
            {
                throw new Exception();
            }
            maxBlocksNeededForSortation = Proccess();
        }
        catch (Exception)
        {
            throw;
        }
        return maxBlocksNeededForSortation;
    }
    int Proccess()
    {
        int totalBlocks = 0;
        List<long> proccessedHeights = new List<long>();
        for (int i = 0; i < _towerHeights?.Count; i++)
        {
            if (i == 0)
            {
                proccessedHeights.Add(_towerHeights[i]);
                totalBlocks++;
            }
            else if (_towerHeights?[i - 1] < _towerHeights?[i])
            {
                if (proccessedHeights.Contains(_towerHeights[i]))
                {
                    continue;
                }
                else
                {
                    proccessedHeights.Add(_towerHeights[i]);
                    totalBlocks++;
                }
            }
            else
            {
                continue;
            }
        }
        return totalBlocks;

    }
}
