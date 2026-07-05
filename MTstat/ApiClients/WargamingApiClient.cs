namespace MTstat.ApiClients;
using MTstat.Models;
using System.Text.Json;

public class WargamingApiClient : IWargamingApiClient
{
    
    private const string ApplicationId = "006d9f9399c0f834d68d2087b2a76aca";
    private HttpClient client = new HttpClient();
    private const string WotUrlList = $"https://api.worldoftanks.eu/wot/account/list/?application_id={ApplicationId}&search=";
    private const string WotUrlStat = $"https://api.worldoftanks.eu/wot/account/info/?application_id={ApplicationId}&account_id=";
    
    
    public async Task<int> GetAccountIdAsync(string nickname)
    {
        var WotResponse = await client.GetAsync($"{WotUrlList}{nickname}");
        var WotJson = await WotResponse.Content.ReadAsStringAsync();
        using JsonDocument doc = JsonDocument.Parse(WotJson);
        return doc.RootElement.GetProperty("data")[0].GetProperty("account_id").GetInt32();
        
    }

    public async Task<PlayerStats> GetPlayerStatsAsync(int accountId)
    {
        var WotStat = await client.GetAsync($"{WotUrlStat}{accountId}");
        var WotJson2 = await WotStat.Content.ReadAsStringAsync();
        using JsonDocument doc2 = JsonDocument.Parse(WotJson2);
        var accountState = doc2.RootElement.GetProperty("data").GetProperty($"{accountId}").GetProperty("statistics").GetProperty("all");
        var stats = JsonSerializer.Deserialize<PlayerStats>(accountState.ToString());
        if (stats is null)
        {
            throw new Exception("No stats found");
        }
        return stats;
    }
}