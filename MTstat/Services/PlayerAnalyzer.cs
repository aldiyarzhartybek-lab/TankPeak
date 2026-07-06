using MTstat.Models;
namespace MTstat.Services;

public class PlayerAnalyzer : IPlayerAnalyzer
{    
    public AnalysisResult Analyze(PlayerStats playerStats)
    {
        var result = new AnalysisResult();
        result.WinRate = Math.Round((double) playerStats.Wins / playerStats.Battles * 100 ,2) ;
        result.Survived = Math.Round((double) playerStats.SurvivedBattles / playerStats.Battles * 100 ,2) ;
        result.AvgDamage = playerStats.DamageDealt / playerStats.Battles;
        if (result.WinRate < 49)
        {
            result.Weaknesses.Add("Низкий винрейт");
        }

        if (result.Survived < 30)
        {
            result.Weaknesses.Add("Низкая выживаемость");
        }

        if (result.AvgDamage < 2000)
        {
            result.Weaknesses.Add("Малый средний урон");
        }
        
        return result;
        
    }
}