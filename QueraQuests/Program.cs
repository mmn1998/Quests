// See https://aka.ms/new-console-template for more information
using QueraQuests.SandTowers;
using System;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
#region Sand Towers
#region Input 1
//int totalTowers = 3;
//List<long> towersHeights = new List<long> { 1, 2, 3 };
#endregion
#region Input 2
int totalTowers = 4;
List<long> towersHeights = new List<long> { 2,1,3,2 };
#endregion
var sandTowers = new SandTowers(TotalTowers: totalTowers, TowerHeights: towersHeights);
Console.WriteLine(sandTowers.CalculateMostBlocksForSortation());
#endregion
