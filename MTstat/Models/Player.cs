using System.Text.Json.Serialization;

namespace MTstat.Models;

public class Player
{
    [JsonPropertyName("nickname")]
    public string Name { get; set; }
    [JsonPropertyName("account_id")]
    public int AccountId { get; set; }
}