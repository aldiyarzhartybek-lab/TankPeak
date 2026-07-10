namespace MTstat.Models;
using System.Text.Json.Serialization;

public class PlayerStats
{
    public int Id { get; set;}
    [JsonPropertyName("battles")]
    public int Battles { get; set; }
    [JsonPropertyName("wins")]
    public int Wins { get; set; }
    [JsonPropertyName("losses")]
    public int Losses { get; set; }
    [JsonPropertyName("damage_dealt")]
    public int DamageDealt { get; set; }
    [JsonPropertyName("hits_percents")]
    public int HitsPercents { get; set; }
    [JsonPropertyName("survived_battles")]
    public int SurvivedBattles { get; set; }
}