using MTstat.Models;
namespace MTstat.Services;

public interface IPlayerAnalyzer
{ 
 AnalysisResult Analyze(PlayerStats playerStats); 
    
}