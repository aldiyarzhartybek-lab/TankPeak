using MTstat.Models;
namespace MTstat.Services;

public class PlayerAnalyzer : IPlayerAnalyzer
{
    private const double MinWinRate = 49;
    private const double MinSurvived = 40;
    private const int MinAvgDamage  = 1800;
    public AnalysisResult Analyze(PlayerStats playerStats)
    {
        var result = new AnalysisResult();
        result.WinRate = Math.Round((double) playerStats.Wins / playerStats.Battles * 100 ,2) ;
        result.Survived = Math.Round((double) playerStats.SurvivedBattles / playerStats.Battles * 100 ,2) ;
        result.AvgDamage = playerStats.DamageDealt / playerStats.Battles;
        if (result.WinRate < MinWinRate)
        {
            result.Weaknesses.Add(WeaknessType.LowWinRate);
        }

        if (result.Survived < MinSurvived)
        {
            result.Weaknesses.Add(WeaknessType.LowSurvival);
        }

        if (result.AvgDamage < MinAvgDamage)
        {
            result.Weaknesses.Add(WeaknessType.LowAvgDamage);
        }
        
        return result;
        
    }
}