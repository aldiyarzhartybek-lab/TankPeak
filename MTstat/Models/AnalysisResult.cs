namespace MTstat.Models;

public class AnalysisResult 
{
    public double WinRate { get; set; }
    public double Survived { get; set; }
    public int AvgDamage {get; set;}
    public bool HasBattles { get; set; }
    
    
    public List<WeaknessType> Weaknesses { get; set; } = new();
}